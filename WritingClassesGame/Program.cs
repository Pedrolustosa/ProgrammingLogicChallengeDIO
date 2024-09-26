using WritingClassesGame.Entities;

Console.WriteLine("Digite o nome do herói:");
string nome = Console.ReadLine();
Console.WriteLine("Digite a idade do herói:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o tipo do herói (mago, guerreiro, monge, ninja):");
string tipo = Console.ReadLine();
Heroi heroi = new(nome, idade, tipo);
heroi.Atacar();
