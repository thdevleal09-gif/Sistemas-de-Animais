using Sistemas_de_Animais;

List<Animal> animais = new List<Animal>();


Console.WriteLine("===== SISTEMA DE ANIMAIS =====");
Console.WriteLine();
Console.WriteLine("1 - Cadastrar cachorro");
Console.WriteLine("2 - Cadastrar gato");
Console.WriteLine("3 - Cadastrar pássaro");
Console.WriteLine("4 - Listar animais");
Console.WriteLine("5 - Emitir som");
Console.WriteLine("6 - Alimentar animal");
Console.WriteLine("7 - Sair");
Console.WriteLine();

Console.Write("Escolha: ");
int opcao = int.Parse(Console.ReadLine()!);

int escolha = 0;

while (opcao != 7)
{
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o nome do animal:");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe a idade do animal:");
            int idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o Peso do animal:");
            double peso = double.Parse(Console.ReadLine()!);
            Cachorro cachorro = new Cachorro(nome, idade, peso);
            animais.Add(cachorro);
            break;



        case 2:
            Console.WriteLine("Informe o nome do animal:");
            string nome1 = Console.ReadLine()!;

            Console.WriteLine("Informe a idade do animal:");
            int idade1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o Peso do animal:");
            double peso1 = double.Parse(Console.ReadLine()!);
            Gato gato = new Gato(nome1, idade1, peso1);
            animais.Add(gato);
            break;

        case 3:
            Console.WriteLine("Informe o nome do animal:");
            string nome2 = Console.ReadLine()!;

            Console.WriteLine("Informe a idade do animal:");
            int idade2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o Peso do animal:");
            double peso2 = double.Parse(Console.ReadLine()!);
            Passaro passaro = new Passaro(nome2, idade2, peso2);
            animais.Add(passaro);
            break;

        case 4:
            Console.WriteLine("===== LISTA DE ANIMAIS =====");
            foreach (Animal animal in animais)
            {
                Console.WriteLine($"Nome: {animal.Nome}");
                Console.WriteLine($"Idade: {animal.Idade}");
                Console.WriteLine($"Peso: {animal.Peso} kg");
                Console.WriteLine();
            }
            break;

        case 5:
            Console.WriteLine("===== EMITIR SOM =====");
            foreach (Animal animal in animais)
            {
                animal.EmitSom();
            }
            break;

        case 6:
            Console.WriteLine("===== ALIMENTAR ANIMAL =====");
            foreach (Animal animal in animais)
            {
                animal.Alimentar();
            }
            break;

        case 7:
            Console.WriteLine("===== SAIR =====");
            Console.WriteLine("Obrigado por usar o sistema!");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;


    }

    escolha++; 
  
}

