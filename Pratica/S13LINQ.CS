/*
    LANGUAGE-INTEGRATED QUERY LINQ - ferramenta para consulta em diferentes tipos de coleções como listas, arrays, dicionários, conjuntos
    suporte a consulta em banco de dados
    IEnumerable(coleção que somente pode ser iterada e exibida, sem alterações, e pode ser implementada por vários tipos de coleções) e IQueryable
    List<T> utilizar quando for necessário editar e alterar os dados
    query syntax ou method syntax (métodos de extensão)
    deferred execution
    :filtro, ordenação, agrupamento, junção, projeção, agregação, quantifiers, elementos, set, particionamento, concatenação, equality, geração, conversão
*/
public class SectionLINQ
{
    IEnumerable<Funcionario> funcionarios = Database.GetFuncionarios();

    public void ImprimirUsuarios()
    {
        foreach (var funcionario in funcionarios)
        {
            System.Console.WriteLine($"{funcionario}");
        }
    }

    /*
        WHERE + ORDERBY,THENBY(ordenação); SUM,AVERAGE,COUNT(cálculos); SELECT(projeção, nova coleção, etc)
        delegate FUNC (faz algo e retorna algo)
    */
    public void TestarFiltros()
    {
        Funcionario? funcionario;

        try
        {
            funcionario = funcionarios.First(u => u.Name == "Juliana Costa" && u.Birth == new DateTime(1992, 12, 19));
            funcionario = funcionarios.Last(u => u.City != "Toronto");
            funcionario = funcionarios.Single(u => u.Email == "camila.rezende@yahoo.com");
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"exceção: {e.Message}");
        }

        funcionario = funcionarios.FirstOrDefault(u => u.Name == "Juliana Costa" && u.Birth == new DateTime(1992, 12, 19));
        funcionario = funcionarios.LastOrDefault(u => u.City.StartsWith("Toronto"));
        funcionario = funcionarios.SingleOrDefault(u => u.Email.Contains("camila.rezende@yahoo.com"));

        var aux = funcionarios.Sum(u => u.Salary);
        aux = funcionarios.Average(u => u.Salary);
        aux = funcionarios.Count();

        var fFiltrados = funcionarios
                                .Where(u => u.City == "São Paulo" && u.Salary > 4000)
                                .OrderBy(u => u.Name);

        var fAgrupados = funcionarios
                                .GroupBy(u => u.Country)
                                .OrderBy(g => g.Key);

        // foreach (var grupo in fAgrupados)
        // {
        //     System.Console.WriteLine($"grupo:{grupo.Key} count:{grupo.Count()}");

        //     foreach (var f in grupo)
        //     {
        //         System.Console.WriteLine(f);
        //     }
        // }

        /*
            SELECT: especificar quais propriedades devem ser recuperadas
            para execução imediata: ToList, ToArray, AsEnumerable, AsQueryable, ToDictionary, ToLookup
        */
        funcionarios = Database.GetFuncionarios().ToList(); // execução imediata

        IEnumerable<string> fNomes = Database.GetFuncionarios().Select(f => f.Name);

        funcionarios = funcionarios
                .Select(u => new Funcionario()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Login = u.Login
                }).ToList();

        var tFuncionarios = Database.GetFuncionarios()
                .Select(f => new
                {
                    Nome = f.Name,
                    Nascimento = f.Birth,
                    Idade = DateTime.Now.Year - f.Birth.Year,
                    SalarioAnual = f.Salary * 12
                }).ToList();

        /*
            operações de conjuntos: distinct, except, intersect, union
        */
        List<Funcionario> brjpca = Database.GetFuncionarios()
                        .Where(f => f.Country == "Brasil" || f.Country == "Japão" || f.Country == "Canadá").ToList();
        List<Funcionario> bruspt = Database.GetFuncionarios()
                        .Where(f => f.Country == "Brasil" || f.Country == "EUA" || f.Country == "Portugal").ToList();

        var intersect = brjpca.IntersectBy(bruspt.Select(f=>f.Name), f => f.Name); // retorna os elementos que forem contidos em ambas coleções ao mesmo tempo
        var union = brjpca.Union(bruspt); // retorna a união entre as coleções
        var except = brjpca.ExceptBy(bruspt.Select(f=>f.Name), f => f.Name); // retorna os elementos que só existem na primeira coleção

        System.Console.WriteLine($"intersect count {intersect.Count()}");       
        System.Console.WriteLine($"intersect count {union.Count()}");       
        System.Console.WriteLine($"intersect count {except.Count()}");       
    }

    public void ExibirLista<T>(IEnumerable<T> lista)
    {
        foreach (var t in lista)
        {
            System.Console.WriteLine(t);
        }
    }
}