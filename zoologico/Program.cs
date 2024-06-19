using zoologico;

Console.WriteLine("## Zoológico ##\n");

//Registrando Animais
List<IAnimal> animais =
[
    new AnimalTerrestre(1, "Zebra", 'F', TiposAnimais.Mamifero, "Lulu", "Preta e Branca", new DateTime(2020, 8, 12), 65),
    new AnimalAquatico(2, "Golfinho", 'M', TiposAnimais.Mamifero, "Alex", "Cinza", new DateTime(2022, 1, 7), 300),
    new AnimalAquatico(3, "Peixe-palhaço", 'M', TiposAnimais.Peixe, "Nemo", "Laranja, Branco e Preto", new DateTime(2023, 1, 27), 32),
    new AnimalAereo(4, "Águia Real", 'F', TiposAnimais.Ave, "Storm", "Castanho-escura", new DateTime(2022, 6, 9), 6000),
];

//Listando Animais do Zoologico e consultando habilidades
foreach (var animal in animais)
{
    Console.WriteLine("\n-----------------------------------------------------\n");
    animal.Habilidade();
}

Console.ReadKey();
