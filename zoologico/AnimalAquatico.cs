namespace zoologico
{
    internal class AnimalAquatico: IAnimal
    {
        public int Id { get; set; }
        public string? Especie { get; set; }
        public char? Sexo { get; set; }
        public TiposAnimais Tipo { get; set; }
        public GrupoAnimal Grupo { set; get; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }
        public DateTime DataNascimento { get; set; }
        public double? Profundidade { get; set; }
        public string? UnidadeMedidaProfundidade { get; set; }

        public AnimalAquatico(int id, string especie, char sexo, TiposAnimais tipo, string nome, string cor, DateTime dataNascimento, double profundidade, string unidadeMedidaProfundidade = "m")
        {
            Id = id;
            Especie = especie;
            Sexo = sexo;
            Tipo = tipo;
            Grupo = GrupoAnimal.Aquatico;
            Nome = nome;
            Cor = cor;
            DataNascimento = dataNascimento;
            Profundidade = profundidade;
            UnidadeMedidaProfundidade = unidadeMedidaProfundidade;
        }

        public void Habilidade()
        {
            Console.WriteLine($"\nO animal {Especie}, denominado {Nome} é um animal {Grupo}, sendo capaz de descer até {Profundidade} {UnidadeMedidaProfundidade} de profundidade.\n");

            Console.WriteLine("Demonstração ...");
            Descer();
            Console.WriteLine(". . .");
            Subir();
        }

        public void Descer()
        {
            Console.WriteLine($"\n{Nome} está descendo mais no meio aquático, e pode chegar a profundidade de {Profundidade} {UnidadeMedidaProfundidade}.\n");
        }

        public void Subir()
        {
            Console.WriteLine($"\n{Nome} está subindo mais no meio aquático\n");
        }
    }
}
