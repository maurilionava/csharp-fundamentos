// Arquivo: InMemoryDatabase.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyData
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public decimal Icms { get; set; } // alíquota (0.12m = 12%)
        public int StockQty { get; set; }
        public int DistributorId { get; set; }
    }

    public sealed class Distributor
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ContactEmail { get; set; } = "";
        public string ContactPhone { get; set; } = "";
        public int LeadTimeDays { get; set; } // prazo médio de entrega
        public int MinOrderQty { get; set; }  // pedido mínimo
        public string UF { get; set; } = "";  // estado (para brincar com ICMS, frete, etc.)
    }

    /// <summary>
    /// Banco de dados em memória para estudos de LINQ.
    /// - 12 Distribuidoras
    /// - 150 Produtos (com Category, Manufacturer, ICMS, estoque etc.)
    /// 
    /// Exemplos de uso (em Program.cs):
    /// 
    /// using StudyData;
    /// 
    /// var db = InMemoryDataContext.Create();
    /// 
    /// // 1) Join simples Produto x Distribuidora:
    /// var q1 = from p in db.Products
    ///          join d in db.Distributors on p.DistributorId equals d.Id
    ///          where p.StockQty <= 10
    ///          orderby p.StockQty, p.Name
    ///          select new { p.Id, p.Name, p.StockQty, d.Name, d.ContactEmail };
    /// 
    /// // 2) GroupBy por fabricante, somando estoque e valor total em estoque:
    /// var q2 = db.Products
    ///           .GroupBy(p => p.Manufacturer)
    ///           .Select(g => new {
    ///               Manufacturer = g.Key,
    ///               Items = g.Count(),
    ///               TotalStock = g.Sum(x => x.StockQty),
    ///               StockValue = g.Sum(x => x.StockQty * x.UnitPrice)
    ///           })
    ///           .OrderByDescending(x => x.StockValue);
    /// 
    /// // 3) Projeção com ICMS calculado por item:
    /// var q3 = db.Products
    ///            .Select(p => new {
    ///                p.Id, p.Name, p.UnitPrice, p.Icms,
    ///                PriceWithIcms = p.UnitPrice * (1 + p.Icms)
    ///            });
    /// 
    /// // 4) Produtos com alerta de estoque e contato da distribuidora:
    /// var alerts = db.GetLowStockProducts(threshold: 5)
    ///                .Join(db.Distributors, p => p.DistributorId, d => d.Id,
    ///                      (p, d) => new {
    ///                         p.Name, p.StockQty, d.Name, d.ContactEmail, d.MinOrderQty
    ///                      });
    /// </summary>
    public sealed class InMemoryDataContext
    {
        public List<Product> Products { get; } = new();
        public List<Distributor> Distributors { get; } = new();

        private InMemoryDataContext() { }

        public static InMemoryDataContext Create()
        {
            var ctx = new InMemoryDataContext();
            ctx.SeedDistributors();
            ctx.SeedProducts(150); // gere 150 produtos
            return ctx;
        }

        /// <summary>
        /// Retorna produtos com estoque menor ou igual ao limiar.
        /// </summary>
        public IEnumerable<Product> GetLowStockProducts(int threshold) =>
            Products.Where(p => p.StockQty <= threshold);

        private void SeedDistributors()
        {
            var names = new[]
            {
                "Distribuidora Alfa", "Distribuidora Beta", "Distribuidora Gama", "Distribuidora Delta",
                "Distribuidora Épsilon", "Distribuidora Zeta", "Distribuidora Sigma", "Distribuidora Ômega",
                "Distribuidora Prisma", "Distribuidora Nimbus", "Distribuidora Atlas", "Distribuidora Boreal"
            };

            var ufs = new[] { "SP", "RJ", "MG", "RS", "PR", "SC", "BA", "PE", "CE", "GO", "ES", "DF" };

            for (int i = 0; i < names.Length; i++)
            {
                Distributors.Add(new Distributor
                {
                    Id = i + 1,
                    Name = names[i],
                    ContactEmail = Slugify(names[i]) + "@exemplo.com.br",
                    ContactPhone = $"+55 (11) 9{i + 1:000}-0000",
                    LeadTimeDays = 2 + (i % 7),        // 2..8 dias
                    MinOrderQty = 5 + (i % 6) * 5,     // 5,10,15,20,25,30
                    UF = ufs[i % ufs.Length]
                });
            }
        }

        private void SeedProducts(int count)
        {
            // Categorias e fabricantes para variação determinística
            var categories = new[]
            {
                "Periféricos", "Armazenamento", "Monitores", "Redes", "Componentes",
                "Impressão", "Energia", "Acessórios", "Software", "Cozinha"
            };

            var manufacturers = new[]
            {
                "TechNova", "ByteWorks", "Electra", "NordicSys", "Amperon",
                "HelixCorp", "Lumina", "OrionTech", "Vortex", "AtlasGear"
            };

            var baseDescriptions = new[]
            {
                "Linha profissional com garantia estendida.",
                "Modelo de alto desempenho para uso intenso.",
                "Versão econômica com excelente custo-benefício.",
                "Design compacto e baixo consumo.",
                "Compatível com múltiplas plataformas.",
                "Indicado para escritórios e home office.",
                "Série gamer com resposta rápida.",
                "Ideal para ambientes industriais.",
                "Certificação energética e baixa emissão.",
                "Edição limitada com recursos avançados."
            };

            // ICMS rotativo (ex.: 12%, 17%, 18%, 7%)
            var icmsCycle = new[] { 0.12m, 0.17m, 0.18m, 0.07m };

            // Alguns nomes-base para variar o Name por categoria
            var nameBases = new Dictionary<string, string[]>
            {
                ["Periféricos"] = new[] { "Teclado", "Mouse", "Headset", "Webcam", "Mousepad" },
                ["Armazenamento"] = new[] { "SSD", "HDD", "NVMe", "PenDrive", "Cartão SD" },
                ["Monitores"] = new[] { "Monitor", "Display", "Painel", "Tela", "Ultrawide" },
                ["Redes"] = new[] { "Roteador", "Switch", "Access Point", "Placa de Rede", "Modem" },
                ["Componentes"] = new[] { "Processador", "Placa de Vídeo", "Memória RAM", "Placa-Mãe", "Fonte" },
                ["Impressão"] = new[] { "Impressora", "Multifuncional", "Toner", "Cartucho", "Plotter" },
                ["Energia"] = new[] { "Nobreak", "Estabilizador", "Filtro de Linha", "Inversor", "Bateria" },
                ["Acessórios"] = new[] { "Suporte", "Base", "Cabo", "Adaptador", "Case" },
                ["Software"] = new[] { "Licença Office", "Antivírus", "Backup", "IDE", "Sistema Operacional" },
                ["Cozinha"] = new[] { "Liquidificador", "Cafeteira", "Torradeira", "Mixer", "Fritadeira" },
            };

            var rndLike = new Deterministic(); // sem aleatoriedade real; apenas variação repetível

            for (int i = 1; i <= count; i++)
            {
                var cat = categories[(i - 1) % categories.Length];
                var maker = manufacturers[(i - 1) % manufacturers.Length];
                var desc = baseDescriptions[(i - 1) % baseDescriptions.Length];
                var icms = icmsCycle[(i - 1) % icmsCycle.Length];

                var namePool = nameBases[cat];
                var baseName = namePool[(i - 1) % namePool.Length];
                var sizeOrVariant = VariantSuffix(i, cat);

                var name = $"{baseName} {sizeOrVariant}";
                var sku = $"{Abbr(cat)}-{Abbr(baseName)}-{i:0000}";

                // Preço e estoque com variação determinística
                var price = BasePriceForCategory(cat) + (decimal)((i % 7) * 9.9) + (i % 3);
                price = Math.Round(price, 2);

                var stock = (i * 7 + (i % 5) * 3) % 60;     // 0..59, bom p/ brincar com baixo estoque
                var distId = ((i - 1) % 12) + 1;            // 1..12

                Products.Add(new Product
                {
                    Id = i,
                    Sku = sku,
                    Name = name,
                    Description = $"{desc} Categoria: {cat}. Fabricante: {maker}.",
                    Category = cat,
                    Manufacturer = maker,
                    UnitPrice = price,
                    Icms = icms,
                    StockQty = stock,
                    DistributorId = distId
                });
            }
        }

        // Valor base por categoria (para compor UnitPrice)
        private static decimal BasePriceForCategory(string category) => category switch
        {
            "Periféricos" => 59.90m,
            "Armazenamento" => 129.90m,
            "Monitores" => 849.90m,
            "Redes" => 139.90m,
            "Componentes" => 399.90m,
            "Impressão" => 299.90m,
            "Energia" => 219.90m,
            "Acessórios" => 29.90m,
            "Software" => 199.00m,
            "Cozinha" => 149.90m,
            _ => 99.90m
        };

        private static string VariantSuffix(int i, string category)
        {
            // Variantes plausíveis por categoria (tamanho, capacidade, etc.)
            return category switch
            {
                "Periféricos" => (i % 5) switch { 0 => "Mecânico", 1 => "Sem Fio", 2 => "RGB", 3 => "Low Profile", _ => "Ergonômico" },
                "Armazenamento" => (i % 5) switch { 0 => "256GB", 1 => "512GB", 2 => "1TB", 3 => "2TB", _ => "4TB" },
                "Monitores" => (i % 5) switch { 0 => "24\"", 1 => "27\"", 2 => "29\" Ultrawide", 3 => "32\"", _ => "34\" Ultrawide" },
                "Redes" => (i % 5) switch { 0 => "AC1200", 1 => "AX1800", 2 => "AX3000", 3 => "Gigabit", _ => "2.5GbE" },
                "Componentes" => (i % 5) switch { 0 => "Entry", 1 => "Mid", 2 => "Pro", 3 => "XT", _ => "Ultra" },
                "Impressão" => (i % 5) switch { 0 => "Tinta", 1 => "Laser", 2 => "Tanque", 3 => "A3", _ => "Wireless" },
                "Energia" => (i % 5) switch { 0 => "600VA", 1 => "1000VA", 2 => "1400VA", 3 => "2000VA", _ => "3000VA" },
                "Acessórios" => (i % 5) switch { 0 => "1m", 1 => "1.5m", 2 => "2m", 3 => "3m", _ => "5m" },
                "Software" => (i % 5) switch { 0 => "Anual", 1 => "Mensal", 2 => "Perpétuo", 3 => "Acadêmico", _ => "Empresarial" },
                "Cozinha" => (i % 5) switch { 0 => "700W", 1 => "900W", 2 => "1.2L", 3 => "1.5L", _ => "2L" },
                _ => $"V{i % 5}"
            };
        }

        private static string Abbr(string s)
        {
            // Abrevia nome para SKU (somente letras maiúsculas e primeiras 3-5)
            var letters = new string(s.Where(char.IsLetter).ToArray()).ToUpperInvariant();
            return letters.Length <= 5 ? letters : letters.Substring(0, 5);
        }

        private sealed class Deterministic
        {
            // Classe de apoio caso queira ampliar com variação determinística (não usada agora).
            private int _seed = 1;
            public int Next(int min, int max)
            {
                _seed = unchecked(_seed * 1103515245 + 12345);
                var val = (_seed >> 16) & 0x7FFF;
                return min + (val % Math.Max(1, (max - min)));
            }
        }
        
        private static string Slugify(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";

            // Mantém apenas letras e números, substitui espaços por "."
            var arr = input
                .ToLowerInvariant()
                .Replace(" ", ".");

            // Remove acentos de forma simplificada
            arr = arr.Normalize(System.Text.NormalizationForm.FormD);
            var chars = arr.Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark);
            return new string(chars.ToArray()).Normalize(System.Text.NormalizationForm.FormC);
        }

    }
}

/*
Notas para prática de LINQ:

1) Join Produto x Distribuidora
--------------------------------
var db = InMemoryDataContext.Create();
var join1 =
    from p in db.Products
    join d in db.Distributors on p.DistributorId equals d.Id
    select new { p.Id, p.Name, p.Category, p.StockQty, d.Name, d.ContactEmail };

2) Filtro e ordenação
---------------------
var baixos =
    db.Products
      .Where(p => p.StockQty <= 5)
      .OrderBy(p => p.StockQty)
      .ThenBy(p => p.Name);

3) Projeção com preço c/ ICMS
-----------------------------
var valores = db.Products.Select(p => new {
    p.Id, p.Name, p.UnitPrice, p.Icms,
    PriceWithIcms = p.UnitPrice * (1 + p.Icms)
});

4) GroupBy por categoria e fabricante
------------------------------------
var grupos =
    db.Products
      .GroupBy(p => new { p.Category, p.Manufacturer })
      .Select(g => new {
          g.Key.Category,
          g.Key.Manufacturer,
          Count = g.Count(),
          TotalStock = g.Sum(x => x.StockQty),
          AvgPrice = g.Average(x => x.UnitPrice)
      })
      .OrderByDescending(x => x.TotalStock);

5) Reposição: alertar distribuidora (join + filtro)
---------------------------------------------------
var reposicao =
    db.GetLowStockProducts(5)
      .Join(db.Distributors, p => p.DistributorId, d => d.Id,
            (p, d) => new {
                Produto = p.Name, p.StockQty, Dist = d.Name, d.ContactEmail, d.MinOrderQty
            });

*/
