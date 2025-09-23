using StudyData;

public class LINQ
{
    public void Testar()
    {
        InMemoryDataContext inMemoryDataContext = InMemoryDataContext.Create();
        var produtos = inMemoryDataContext.Products;
        var produtosArray = produtos.ToArray(); // conversão
        var produtosList = produtos.ToList(); // conversão

        var distribuidoras = inMemoryDataContext.Distributors;
        // ImprimirListaProdutos(produtos, "PRODUTOS");

        // where
        var produtosFiltrados = produtos.Where(p => p.StockQty == 0); // execução adiada, consulta ainda não realizada
        // where contains
        produtosFiltrados = produtos.Where(p => p.Category.Contains("CO", StringComparison.InvariantCultureIgnoreCase)); // cozinha e componentes
        // where orderby
        produtosFiltrados = produtos.Where(p => p.StockQty > 0)
                                        .OrderBy(p => p.Name);
        // where thenby
        produtosFiltrados = produtos.Where(p => p.StockQty > 0)
                                        .OrderBy(p => p.Category)
                                        .ThenBy(p => p.Name);
        // where sum, average, count
        var totalValorProdutos = produtos.Where(p => p.StockQty > 0)
                                       .Sum(p => p.StockQty * p.UnitPrice);
        var QtdeProdutosEstoque = produtos.Sum(p => p.StockQty);
        var MediaPrecoUnitario = produtos.Average(p => p.UnitPrice);
        var QtdeProdutosEmEstoque = produtos.Where(p => p.StockQty > 0)
                                            .Count();
        // select
        var listaSelect = produtos.Select(p=>p.Id);
        var r = produtos.Select(p=> new
        {
            Nome = p.Name,
            PrecoTotalEmEstoque = p.UnitPrice * p.StockQty
        });

        foreach (var a in r)
        {
            System.Console.WriteLine($"{a.Nome} {a.PrecoTotalEmEstoque}");
        }

        ImprimirListaProdutos(produtosFiltrados.ToList(), "PRODUTOS EM ESTOQUE ORDENADOS POR CATEGORIA E DEPOIS POR NOME"); // .tolist executa a consulta e carrega resultado na memória
        System.Console.WriteLine($"TOTAL DE VALOR EM ESTOQUE: {totalValorProdutos:C2}");
        System.Console.WriteLine($"QTDE DE PRODUTOS EM ESTOQUE: {QtdeProdutosEmEstoque}");
        System.Console.WriteLine($"MÉDIA DO PREÇO UNITÁRIO: {MediaPrecoUnitario}");
        System.Console.WriteLine($"QTDE DE PRODUTOS EM ESTOQUE: {QtdeProdutosEmEstoque}");
        
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