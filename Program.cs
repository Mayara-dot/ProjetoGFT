using static System.Console;
using ProjetoGFT.src.Entities;

class Program
{
    static void Main()
    {
        Knight knight = new Knight("Arus", 28, "Knight");
        Wizard whiteMage = new Wizard("Jenica", 28, "White Wizard");
        Wizard blackMage = new Wizard("Topapa", 28, "Black Wizard");
        Ninja ninja = new Ninja("Josenildo", 28, "Ninja");


        WriteLine($@"Bem vindo ao jogo!!
        Escolha o seu herói para essa batalha!!
        Temos:
        Knight - O melhor guerreiro!
        White Mage - Com sua magia branca!
        Black Mage - Com sua magia negra!
        Ninja - Com as melhores habilidades marciais!
         ");

        var heroi = ReadLine();

        switch(heroi) {
            case "Knight":
            WriteLine($"Você escolheu {knight}Ótima escolha! Atacando...");
            WriteLine(knight.Attack());
            break;

            case "White Mage":
            WriteLine($"Você escolheu {whiteMage}Ótima escolha! Atacando...");
            WriteLine(whiteMage.Attack());
            break;
            
            case "Ninja":
            WriteLine($"Você escolheu {ninja}Ótima escolha! Atacando...");
            WriteLine(ninja.Attack());
            break;

            case "Black Mage":
            WriteLine($"Você escolheu {blackMage}Ótima escolha! Ataque com um valor bonus! ");
            int bonus = int.Parse(ReadLine());
            WriteLine(blackMage.Attack(bonus));
            break;
        
            default: 
            WriteLine($"Esse herói ainda não está disponível");
            break;
        }
         
    }
}

