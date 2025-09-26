/*
* LINQ - Language Integrated Query
* - Consulta integrada à linguagem
* - Permite consultar coleções de objetos, bancos de dados, XML, etc.
* - Sintaxe semelhante a SQL
* - Operadores principais: where, select, orderby, groupby, join, etc
* - Execução adiada (deferred execution) - consulta é executada quando os dados são iterados
* - Pode ser usado com qualquer coleção que implemente IEnumerable<T> ou IQueryable

* TOREMEMBER: a execução imediata da consulta é realizada quando os métodos abaixo são invocados
* ToList, ToArray, AsEnumerable, AsQuieryable, ToDictionary, ToLookup
*/
using StudyData;
public class LINQ
{
    public void Testar()
    {
        List<string> brics = new() { "BRASIL", "RUSSIA", "INDIA", "CHINA", "AFRICA DO SUL", "BRASIL" };
        List<string> g7 = new() { "EUA", "CANADA", "FRANCA", "ALEMANHA", "JAPAO", "ITALIA" };
        List<string> linguaPortuguesa = new() { "BRASIL", "PORTUGAL", "ANGOLA", "MOCAMBIQUE" };

        InMemoryDataContext inMemoryDataContext = InMemoryDataContext.Create();

        var produtos = inMemoryDataContext.Products;
        var distribuidoras = inMemoryDataContext.Distributors;

        // WHERE
        var where = produtos.Where(p => p.StockQty == 0); // execução adiada, consulta ainda não realizada
        // ORDENAÇÃO: ORDERBY, THENBY
        var orderby = produtos.OrderBy(p => p.Category).ThenBy(p => p.Name);
        // AGRUPAMENTO: MAX, MIN, SUM, AVERAGE, COUNT
        var max = produtos.Max(p => p.UnitPrice);
        var min = produtos.Min(p => p.UnitPrice);
        var sum = produtos.Sum(p => p.StockQty);
        var average = produtos.Average(p => p.UnitPrice);
        var count = produtos.Count();
        // System.Console.WriteLine($"TOTAL DE VALOR EM ESTOQUE: {totalValorProdutos:C2}");

        // PROJEÇÃO: SELECT, SELECTMANY (LISTA DE LISTAS)
        var listaSelect = produtos.Select(p => p.Id);
        var r = produtos.Select(p => new
        {
            Nome = p.Name,
            PrecoTotalEmEstoque = p.UnitPrice * p.StockQty
        });

        foreach (var a in r)
            System.Console.WriteLine($"{a.Nome} {a.PrecoTotalEmEstoque}");

        // SET - CONJUNTOS: DISTINCT, EXCEPT, INTERSECT, UNION
        var distinct = brics.Distinct(); // remover duplicados
        var except = brics.Except(linguaPortuguesa, StringComparer.OrdinalIgnoreCase); // retornar apenas o que não existe na coleção passada como parâmetro
        var intersect = brics.Intersect(linguaPortuguesa); // retornar o que existe em ambas as coleções ao mesmo tempo
        var union = brics.Union(g7); // retornar os valores de ambas as coleções

        // QUANTIFICAÇÃO: ALL, ANY, CONTAINS
        var all = brics.All(p => p.Contains("A")); // todos os registros devem atender ao requisito
        var any = brics.Any(p => p.StartsWith("BR") && p.EndsWith("IL")); // ao menos um registro deve atender ao requisito
        var contains = brics.Contains("BRASIL");

        // AGRUPAMENTO: GROUPBY, TOLOOKUP (execução imediata)
        var grupos = produtos.GroupBy(p => p.Category);
        var tolookup = produtos.ToLookup(p => p.Category);

        foreach (var grupo in grupos)
        {
            System.Console.WriteLine($"CATEGORIA: {grupo.Key} QTDE: {grupo.Count()}");
            foreach (var registro in grupo)
                System.Console.WriteLine($"\t{registro.Sku}");
        }

        // TODO: GROUPJOIN
        // JUNÇÃO: JOIN, GROUPJOIN
        var join = produtos.Join(
            distribuidoras,
            produto => produto.DistributorId,
            distribuidor => distribuidor.Id,
            (produto, distribuidor) => new
            {
                ProdutoNome = produto.Name,
                DistribuidorNome = distribuidor.Name
            }
        ).ToList();
        foreach (var pd in join)
        {
            System.Console.WriteLine($"{pd.ProdutoNome} {pd.DistribuidorNome}");
        }

        // ELEMENTOS: ELEMENTAT, FIRST, LAST, SINGLE, DEFAULTIFEMPTY
        var elementatordefault = produtos.ElementAtOrDefault(0);
        var firstordefault = produtos.FirstOrDefault(p => p.Name.Contains("ADAPTADOR"));
        var lastordefault = produtos.LastOrDefault(p => p.Icms >= 0.75m);
        var singleordefault = produtos.SingleOrDefault(p => p.Id == 1);
        var defaultifempty = produtos.DefaultIfEmpty();

        try
        {
            var elementat = produtos.ElementAt(0);
            var first = produtos.First(p => p.Category == "COZINHA");
            var last = produtos.Last(p => p.Icms > 0.5m);
            var single = produtos.Single(p => p.StockQty > 100);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

        // CONVERSÃO
        var toarray = produtos.ToArray();
        var tolist = produtos.ToList();
        var todictionary = produtos.ToDictionary(p => p.Id);
        var tolookupConversao = produtos.ToLookup(p => p.Id);
        var asenumerable = produtos.AsEnumerable();
        var asqueryable  = produtos.AsQueryable();
    }

    public void ImprimirListaProdutos(List<Product> lista, string mensagem)
    {
        int cont = 1;

        System.Console.WriteLine($"\n\n### {mensagem} ###\n");

        foreach (var produto in lista)
        {
            System.Console.WriteLine($"{cont}- ID: {produto.Id} NOME: {produto.Name} DESCRIÇÃO: {produto.Description} PREÇO UN: {produto.UnitPrice} SKU: {produto.Sku} ESTOQUE: {produto.StockQty} ICMS: {produto.Icms} CATEGORIA: {produto.Category} DISTRIBUIDOR: {produto.DistributorId} {produto.Manufacturer}");
            cont++;
        }
    }
}