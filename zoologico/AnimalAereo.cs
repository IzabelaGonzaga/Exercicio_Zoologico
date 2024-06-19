namespace zoologico
{
    internal class AnimalAereo: IAnimal
    {
        public int Id { get; set; }
        public string? Especie { get; set; }
        public char? Sexo { get; set; }
        public TiposAnimais Tipo { get; set; }
        public GrupoAnimal Grupo { set; get; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }
        public DateTime DataNascimento { get; set; }
        public double? Altitude { get; set; }
        public string? UnidadeMedidaAltitude { get; set; }

        public AnimalAereo(int id, string especie, char sexo, TiposAnimais tipo, string nome, string cor, DateTime dataNascimento, double altitude, string unidadeMedidaAltitude = "m")
        {
            Id = id;
            Especie = especie;
            Sexo = sexo;
            Tipo = tipo;
            Grupo = GrupoAnimal.Aereo;
            Nome = nome;
            Cor = cor;
            DataNascimento = dataNascimento;
            Altitude = altitude;
            UnidadeMedidaAltitude = unidadeMedidaAltitude;
        }

        public void Habilidade()
        {
            Console.WriteLine($"\nO animal {Especie}, denominado {Nome} é um animal {Grupo}, e pode voar. Chegando a altitudes de {Altitude} {UnidadeMedidaAltitude}.\n");

            Console.WriteLine("Demonstração ...");
            LevantarVoo();
            Console.WriteLine(". . .");
            Pousar();
        }

        public void LevantarVoo()
        {
            Console.WriteLine($"\n{Nome} está levantando voo...\n");
        }

        public void Pousar()
        {
            Console.WriteLine($"\n{Nome} está pousando...\n");
        }
    }
}
