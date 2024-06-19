namespace zoologico
{
    public interface IAnimal
    {
        public int Id { get; set; }
        public string? Especie { get; set; }

        //M -> Macho ou F -> Fêmea
        public char? Sexo { get; set; }
        public TiposAnimais Tipo { get; set; }
        public GrupoAnimal Grupo { get; set; }
        public string? Nome { get; set; }
        public string? Cor {  get; set; }
        public DateTime DataNascimento { get; set; }

        void Habilidade();
    }
}
