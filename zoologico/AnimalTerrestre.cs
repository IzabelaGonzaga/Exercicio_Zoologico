namespace zoologico
{
    internal class AnimalTerrestre : IAnimal
    {
        public int Id { get; set; }
        public string? Especie { get; set; }
        public char? Sexo { get; set; }
        public TiposAnimais Tipo { get; set; }
        public GrupoAnimal Grupo { set;  get; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }
        public DateTime DataNascimento { get; set; }
        public double? Velocidade { get; set; }
        public string? UnidadeMedidaVelocidade { get; set; }

        public AnimalTerrestre(int id, string especie, char sexo, TiposAnimais tipo, string nome, string cor, DateTime dataNascimento, double velocidade, string unidadeMedidaVelocidade = "km/h")
        {
            Id = id;
            Especie = especie;
            Sexo = sexo;
            Tipo = tipo;
            Grupo = GrupoAnimal.Terrestre;
            Nome = nome;
            Cor = cor;
            DataNascimento = dataNascimento;
            Velocidade = velocidade;
            UnidadeMedidaVelocidade = unidadeMedidaVelocidade;
        }

        public void Habilidade()
        {
            Console.WriteLine($"\nO animal {Especie}, denominado {Nome} é um animal {Grupo}, e pode se locomover a velocidade de {Velocidade} {UnidadeMedidaVelocidade}.\n");
        }
    }
}
