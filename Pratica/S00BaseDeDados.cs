public static class Database
{
    public static IEnumerable<Funcionario> GetFuncionarios()
    {
        var users = new List<Funcionario>
        {
            new Funcionario { Id = 1, Name = "Alice Souza", Login = "alice.souza", Password = "alic494!", Birth = new DateTime(1986, 1, 11), City = "Nova York", State = "NY", Country = "EUA", Email = "alice.souza@yahoo.com", Ocupation = "UX Designer", Salary = 9202 },
            new Funcionario { Id = 2, Name = "Bruno Lima", Login = "bruno.lima", Password = "brun385!", Birth = new DateTime(2004, 11, 24), City = "Toronto", State = "ON", Country = "Canadá", Email = "bruno.lima@yahoo.com", Ocupation = "Tester QA", Salary = 3506 },
            new Funcionario { Id = 3, Name = "Carla Mendes", Login = "carla.mendes", Password = "carl711!", Birth = new DateTime(2003, 9, 21), City = "Londres", State = "LDN", Country = "Reino Unido", Email = "carla.mendes@outlook.com", Ocupation = "Técnico de Suporte", Salary = 10966 },
            new Funcionario { Id = 4, Name = "Diego Rocha", Login = "diego.rocha", Password = "dieg934!", Birth = new DateTime(1987, 1, 11), City = "Nova York", State = "NY", Country = "EUA", Email = "diego.rocha@yahoo.com", Ocupation = "Cientista de Dados", Salary = 12414 },
            new Funcionario { Id = 5, Name = "Eduarda Silva", Login = "eduarda.silva", Password = "edua574!", Birth = new DateTime(1986, 7, 10), City = "Toronto", State = "ON", Country = "Canadá", Email = "eduarda.silva@yahoo.com", Ocupation = "UX Designer", Salary = 8757 },
            new Funcionario { Id = 6, Name = "Fábio Castro", Login = "fábio.castro", Password = "fábi330!", Birth = new DateTime(1983, 8, 1), City = "Cidade do México", State = "CDMX", Country = "México", Email = "fábio.castro@yahoo.com", Ocupation = "Analista Funcional", Salary = 9022 },
            new Funcionario { Id = 7, Name = "Gabriel Nunes", Login = "gabriel.nunes", Password = "gabr310!", Birth = new DateTime(1987, 4, 29), City = "Nova York", State = "NY", Country = "EUA", Email = "gabriel.nunes@outlook.com", Ocupation = "Analista de Dados", Salary = 13035 },
            new Funcionario { Id = 8, Name = "Helena Dias", Login = "helena.dias", Password = "hele427!", Birth = new DateTime(1986, 7, 5), City = "Paris", State = "IDF", Country = "França", Email = "helena.dias@protonmail.com", Ocupation = "Desenvolvedora Full-Stack", Salary = 11690 },
            new Funcionario { Id = 9, Name = "Igor Ferreira", Login = "igor.ferreira", Password = "igor661!", Birth = new DateTime(1985, 3, 21), City = "Tóquio", State = "TK", Country = "Japão", Email = "igor.ferreira@yahoo.com", Ocupation = "Cientista de Dados", Salary = 9629 },
            new Funcionario { Id = 10, Name = "Juliana Costa", Login = "juliana.costa", Password = "juli885!", Birth = new DateTime(1992, 12, 19), City = "Londres", State = "LDN", Country = "Reino Unido", Email = "juliana.costa@microsoft.com", Ocupation = "Front-End Developer", Salary = 11167 },
            new Funcionario { Id = 11, Name = "Leonardo Tavares", Login = "leonardo.tavares", Password = "leon808!", Birth = new DateTime(1983, 4, 10), City = "São Paulo", State = "SP", Country = "Brasil", Email = "leonardo.tavares@microsoft.com", Ocupation = "Engenheiro de Testes", Salary = 3729 },
            new Funcionario { Id = 12, Name = "Marina Lopes", Login = "marina.lopes", Password = "mari277!", Birth = new DateTime(1988, 4, 26), City = "Tóquio", State = "TK", Country = "Japão", Email = "marina.lopes@microsoft.com", Ocupation = "DevOps Engineer", Salary = 4472 },
            new Funcionario { Id = 13, Name = "Nicolas Pires", Login = "nicolas.pires", Password = "nico602!", Birth = new DateTime(1991, 2, 17), City = "Lisboa", State = "Lisboa", Country = "Portugal", Email = "nicolas.pires@microsoft.com", Ocupation = "Desenvolvedora Full-Stack", Salary = 11050 },
            new Funcionario { Id = 14, Name = "Olívia Martins", Login = "olívia.martins", Password = "olív635!", Birth = new DateTime(2006, 8, 7), City = "Lisboa", State = "Lisboa", Country = "Portugal", Email = "olívia.martins@outlook.com", Ocupation = "Cientista de Dados", Salary = 10860 },
            new Funcionario { Id = 15, Name = "Paulo Henrique", Login = "paulo.henrique", Password = "paul772!", Birth = new DateTime(1996, 2, 1), City = "Toronto", State = "ON", Country = "Canadá", Email = "paulo.henrique@microsoft.com", Ocupation = "Scrum Master", Salary = 11110 },
            new Funcionario { Id = 16, Name = "Queila Ramos", Login = "queila.ramos", Password = "quei627!", Birth = new DateTime(1993, 5, 15), City = "Paris", State = "IDF", Country = "França", Email = "queila.ramos@microsoft.com", Ocupation = "Engenheira de Dados", Salary = 10092 },
            new Funcionario { Id = 17, Name = "Rafael Gomes", Login = "rafael.gomes", Password = "rafa559!", Birth = new DateTime(2002, 2, 21), City = "Tóquio", State = "TK", Country = "Japão", Email = "rafael.gomes@gmail.com", Ocupation = "Scrum Master", Salary = 6906 },
            new Funcionario { Id = 18, Name = "Sofia Carvalho", Login = "sofia.carvalho", Password = "sofi808!", Birth = new DateTime(1979, 11, 7), City = "Tóquio", State = "TK", Country = "Japão", Email = "sofia.carvalho@yahoo.com", Ocupation = "UX Designer", Salary = 6527 },
            new Funcionario { Id = 19, Name = "Tiago Almeida", Login = "tiago.almeida", Password = "tiag930!", Birth = new DateTime(2001, 3, 29), City = "São Paulo", State = "SP", Country = "Brasil", Email = "tiago.almeida@protonmail.com", Ocupation = "Administrador de Redes", Salary = 3919 },
            new Funcionario { Id = 20, Name = "Vanessa Teixeira", Login = "vanessa.teixeira", Password = "vane371!", Birth = new DateTime(2005, 9, 11), City = "Cidade do México", State = "CDMX", Country = "México", Email = "vanessa.teixeira@gmail.com", Ocupation = "Product Owner", Salary = 6330 },
            new Funcionario { Id = 21, Name = "Wesley Santos", Login = "wesley.santos", Password = "wesl133!", Birth = new DateTime(2006, 4, 8), City = "Cidade do México", State = "CDMX", Country = "México", Email = "wesley.santos@yahoo.com", Ocupation = "Analista Funcional", Salary = 9614 },
            new Funcionario { Id = 22, Name = "Xênia Duarte", Login = "xênia.duarte", Password = "xêni997!", Birth = new DateTime(1980, 8, 24), City = "Berlim", State = "BE", Country = "Alemanha", Email = "xênia.duarte@yahoo.com", Ocupation = "Analista de Dados", Salary = 4085 },
            new Funcionario { Id = 23, Name = "Yuri Meireles", Login = "yuri.meireles", Password = "yuri158!", Birth = new DateTime(1998, 10, 31), City = "Londres", State = "LDN", Country = "Reino Unido", Email = "yuri.meireles@outlook.com", Ocupation = "Técnico de Suporte", Salary = 10460 },
            new Funcionario { Id = 24, Name = "Zilda Campos", Login = "zilda.campos", Password = "zild563!", Birth = new DateTime(2000, 12, 12), City = "Buenos Aires", State = "BA", Country = "Argentina", Email = "zilda.campos@yahoo.com", Ocupation = "DevOps Engineer", Salary = 7457 },
            new Funcionario { Id = 25, Name = "Amanda Torres", Login = "amanda.torres", Password = "aman976!", Birth = new DateTime(2002, 10, 21), City = "Toronto", State = "ON", Country = "Canadá", Email = "amanda.torres@outlook.com", Ocupation = "Desenvolvedora", Salary = 9276 },
            new Funcionario { Id = 26, Name = "Bernardo Monteiro", Login = "bernardo.monteiro", Password = "bern645!", Birth = new DateTime(1983, 8, 21), City = "Nova York", State = "NY", Country = "EUA", Email = "bernardo.monteiro@yahoo.com", Ocupation = "Cientista de Dados", Salary = 10133 },
            new Funcionario { Id = 27, Name = "Camila Rezende", Login = "camila.rezende", Password = "cami774!", Birth = new DateTime(1979, 10, 26), City = "São Paulo", State = "SP", Country = "Brasil", Email = "camila.rezende@yahoo.com", Ocupation = "DevOps Engineer", Salary = 11879 },
            new Funcionario { Id = 28, Name = "Daniel Araújo", Login = "daniel.araújo", Password = "dani415!", Birth = new DateTime(1998, 6, 18), City = "São Paulo", State = "SP", Country = "Brasil", Email = "daniel.araújo@gmail.com", Ocupation = "Scrum Master", Salary = 4888 },
            new Funcionario { Id = 29, Name = "Elaine Castro", Login = "elaine.castro", Password = "elai141!", Birth = new DateTime(1995, 2, 26), City = "Nova York", State = "NY", Country = "EUA", Email = "elaine.castro@microsoft.com", Ocupation = "Scrum Master", Salary = 4539 },
            new Funcionario { Id = 30, Name = "Felipe Barreto", Login = "felipe.barreto", Password = "feli797!", Birth = new DateTime(1997, 8, 3), City = "Londres", State = "LDN", Country = "Reino Unido", Email = "felipe.barreto@gmail.com", Ocupation = "Engenheira de Dados", Salary = 9136 },
            new Funcionario { Id = 31, Name = "Giovana Farias", Login = "giovana.farias", Password = "giov447!", Birth = new DateTime(2003, 11, 13), City = "Berlim", State = "BE", Country = "Alemanha", Email = "giovana.farias@yahoo.com", Ocupation = "UX Designer", Salary = 4046 },
            new Funcionario { Id = 32, Name = "Henrique Duarte", Login = "henrique.duarte", Password = "henr870!", Birth = new DateTime(2001, 1, 18), City = "Buenos Aires", State = "BA", Country = "Argentina", Email = "henrique.duarte@protonmail.com", Ocupation = "Administrador de Sistemas", Salary = 5814 },
            new Funcionario { Id = 33, Name = "Isabela Rocha", Login = "isabela.rocha", Password = "isab940!", Birth = new DateTime(1982, 8, 3), City = "Berlim", State = "BE", Country = "Alemanha", Email = "isabela.rocha@gmail.com", Ocupation = "Desenvolvedora Full-Stack", Salary = 7099 },
            new Funcionario { Id = 34, Name = "João Victor", Login = "joão.victor", Password = "joão850!", Birth = new DateTime(1982, 3, 7), City = "Cidade do México", State = "CDMX", Country = "México", Email = "joão.victor@yahoo.com", Ocupation = "Analista Funcional", Salary = 7915 },
            new Funcionario { Id = 35, Name = "Karen Batista", Login = "karen.batista", Password = "kare907!", Birth = new DateTime(2003, 11, 18), City = "Toronto", State = "ON", Country = "Canadá", Email = "karen.batista@protonmail.com", Ocupation = "Cientista de Dados", Salary = 6471 },
            new Funcionario { Id = 36, Name = "Luan Martins", Login = "luan.martins", Password = "luan353!", Birth = new DateTime(2006, 5, 9), City = "Toronto", State = "ON", Country = "Canadá", Email = "luan.martins@gmail.com", Ocupation = "Administrador de Redes", Salary = 8394 },
            new Funcionario { Id = 37, Name = "Michele Nogueira", Login = "michele.nogueira", Password = "mich790!", Birth = new DateTime(1991, 3, 9), City = "Berlim", State = "BE", Country = "Alemanha", Email = "michele.nogueira@gmail.com", Ocupation = "DevOps Engineer", Salary = 3530 },
            new Funcionario { Id = 38, Name = "Natália Silva", Login = "natália.silva", Password = "natá785!", Birth = new DateTime(1980, 2, 29), City = "Cidade do México", State = "CDMX", Country = "México", Email = "natália.silva@microsoft.com", Ocupation = "Back-End Developer", Salary = 11886 },
            new Funcionario { Id = 39, Name = "Otávio Prado", Login = "otávio.prado", Password = "otáv832!", Birth = new DateTime(1982, 11, 6), City = "Lisboa", State = "Lisboa", Country = "Portugal", Email = "otávio.prado@gmail.com", Ocupation = "Tester QA", Salary = 7760 },
            new Funcionario { Id = 40, Name = "Patrícia Lopes", Login = "patrícia.lopes", Password = "patr422!", Birth = new DateTime(1987, 7, 18), City = "Nova York", State = "NY", Country = "EUA", Email = "patrícia.lopes@gmail.com", Ocupation = "Scrum Master", Salary = 7029 },
            new Funcionario { Id = 41, Name = "Renato Ribeiro", Login = "renato.ribeiro", Password = "rena389!", Birth = new DateTime(1982, 8, 28), City = "Berlim", State = "BE", Country = "Alemanha", Email = "renato.ribeiro@outlook.com", Ocupation = "Analista Funcional", Salary = 7620 },
            new Funcionario { Id = 42, Name = "Sara Freitas", Login = "sara.freitas", Password = "sara775!", Birth = new DateTime(1999, 3, 21), City = "Buenos Aires", State = "BA", Country = "Argentina", Email = "sara.freitas@gmail.com", Ocupation = "Engenheira de Software", Salary = 10451 },
            new Funcionario { Id = 43, Name = "Tatiane Moura", Login = "tatiane.moura", Password = "tati320!", Birth = new DateTime(1987, 4, 22), City = "Tóquio", State = "TK", Country = "Japão", Email = "tatiane.moura@gmail.com", Ocupation = "Cientista de Dados", Salary = 8508 },
            new Funcionario { Id = 44, Name = "Ubirajara Cruz", Login = "ubirajara.cruz", Password = "ubir270!", Birth = new DateTime(1987, 8, 13), City = "Tóquio", State = "TK", Country = "Japão", Email = "ubirajara.cruz@gmail.com", Ocupation = "Back-End Developer", Salary = 6277 },
            new Funcionario { Id = 45, Name = "Vitor Santos", Login = "vitor.santos", Password = "vito862!", Birth = new DateTime(1980, 8, 31), City = "Buenos Aires", State = "BA", Country = "Argentina", Email = "vitor.santos@gmail.com", Ocupation = "DevOps Engineer", Salary = 4899 },
            new Funcionario { Id = 46, Name = "Willian Dias", Login = "willian.dias", Password = "will754!", Birth = new DateTime(1985, 10, 12), City = "Tóquio", State = "TK", Country = "Japão", Email = "willian.dias@protonmail.com", Ocupation = "Engenheiro de Testes", Salary = 10456 },
            new Funcionario { Id = 47, Name = "Yasmin Leite", Login = "yasmin.leite", Password = "yasm514!", Birth = new DateTime(1997, 8, 24), City = "Tóquio", State = "TK", Country = "Japão", Email = "yasmin.leite@microsoft.com", Ocupation = "Técnico de Suporte", Salary = 4196 },
            new Funcionario { Id = 48, Name = "Zeca Barbosa", Login = "zeca.barbosa", Password = "zeca261!", Birth = new DateTime(2007, 4, 18), City = "Paris", State = "IDF", Country = "França", Email = "zeca.barbosa@gmail.com", Ocupation = "Cientista de Dados", Salary = 10767 },
            new Funcionario { Id = 49, Name = "Anita Barros", Login = "anita.barros", Password = "anit338!", Birth = new DateTime(1985, 6, 21), City = "Tóquio", State = "TK", Country = "Japão", Email = "anita.barros@outlook.com", Ocupation = "Front-End Developer", Salary = 12791 },
            new Funcionario { Id = 50, Name = "Caio Ramos", Login = "caio.ramos", Password = "caio326!", Birth = new DateTime(2001, 4, 17), City = "Paris", State = "IDF", Country = "França", Email = "caio.ramos@protonmail.com", Ocupation = "Tester QA", Salary = 5510 },
        };

        return users;
    }
}

public class Funcionario
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime Birth { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public string Ocupation { get; set; }
    public double Salary { get; set; }

    public Funcionario() { }

    public Funcionario(int id, string name, string login, string password, DateTime birth,
            string city, string state, string country, string email, string ocupation, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Login = login;
        this.Password = password;
        this.Birth = birth;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.Email = email;
        this.Ocupation = ocupation;
        this.Salary = salary;
    }

    public override string ToString()
    {
        string usuario = $"ID:{this.Id} NOME:{this.Name} LOGIN:{this.Login} PASSWORD:{this.Password}NASCIMENTO:{this.Birth.ToShortDateString()} CIDADE:{this.City} ESTADO:{this.State} PAÍS:{this.Country} EMAIL:{this.Email} OCUPAÇÃO:{this.Ocupation} SALÁRIO:{this.Salary:C2}\n";
        return usuario;
    }
}