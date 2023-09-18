// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.CompilerServices;

//

// PARTIE 1 : LES TYPES

// Exerce 1 : WriteLine() et ReadLine()

// Console.WriteLine("Quel est votre nom ?");
// string monNom = Console.ReadLine();
// Console.WriteLine("Quel est votre âge ?");
// string monAge = Console.ReadLine();
// Console.WriteLine($"Votre prénom est {monNom} et vous avez {monAge} ans");
// 1 - on envoie une première instruction à la console pour qu'elle écrive une question
// 2 - on déclare une variable monNom en lui attribuant la valeur lue que l'utilisateur vient d'écrire dans la console
// 3 - on fait pareil pour l'âge
// 4 - On affiche dans la console nos résultats

//

//

// Exercice 2 : Les opérateurs

int num1 = 9;
int num2 = 2;

double addition = num1 + num2;
Console.WriteLine(addition);

double soustraction = num1 - num2;
Console.WriteLine(soustraction);

double multiplication = num1 * num2;
Console.WriteLine(multiplication);

double division = num1 / num2;
Console.WriteLine(division);
// Même si on a utilisé le type "double" pour la division, du fait qu'on a divisé 2 int, alors le rsultat sera un int. Ce qui fait 4 comme résultat. Si par contre je type "double" mes 2 variables num1 et num2, alors j'aurais bien comme résulat 4,25

double modulo = num1 % num2;
Console.WriteLine(modulo);

//

//

// Exercice 3 : changement de typage

// Console.WriteLine("Quel est votre prénom ?");
// string theName = Console.ReadLine();
// Console.WriteLine("Quel est votre âge ?");
// int theAge = int.Parse(Console.ReadLine());
// Console.WriteLine($"Vous êtes {theName} et vous avez {theAge} ans !");

// Je suis obligé d'utiliser int.Parse après int theAge, car la saisie de l'utilisateur va être interprétée comme une string. Il faudra donc passer cette saisie en int.

//

// -------------------------------------

//

// PARTIE 2 : LES CONDITIONNELLEZS

//

// Exercice 4 : le IF

// Console.WriteLine("Quel est votre prénom ?");
// string theName = Console.ReadLine();
// Console.WriteLine("Quel est votre âge ?");
// int theAge = int.Parse(Console.ReadLine());
// Console.WriteLine($"Vous êtes {theName} et vous avez {theAge} ans !");
// if(theAge >= 18)
//  {Console.WriteLine("Vous êtes majeur.");
// }
// else 
// {Console.WriteLine("Vous êtes mineur.");
// };

//

//

// Exercice 5 : le nombre mystère

// const int mysterious = 5;
// Console.WriteLine("Quel est votre prénom ?");
// string name = Console.ReadLine();
// Console.WriteLine($"Bonjour {name}, veuillez saisir un chiffre entre 0 et 9.");
// int number = int.Parse(Console.ReadLine());

// if(number==mysterious)
// {Console.WriteLine($"Bravo {name} ! Vous avez gagné !");
// }
// else if(number<mysterious)
// {Console.WriteLine($"Dommage {name}, le chiffre est trop petit.");
// }
// else if(number>mysterious)
// {Console.WriteLine($"Dommage {name}, le chiffre est trop grand.");
// };

//

//

// Exercice 6 : La boucle for

// int[] choices = new int[3];

// for(int i = 0; i<3; i++)
// {
// Console.WriteLine($"Veuillez entrer la valeur {i + 1}.");
// choices[i] = int.Parse(Console.ReadLine());
// }


// for (int i = 0; i<3; i++)
// {
//     Console.WriteLine(choices[i]);
// };

// NOTE 1 : Le but était de demander 3 nombres à l'utilisateur, de les alimenter dans un tableau "choices", et d'afficher chaque élément de ce tableau.
// NOTE 2 : On a du mettre i + 1 uniquement pour l'affichage du message à l'utilisateur. On a choisi de lui dire "Veuillez entrer la valeur 1" (mais comme on prend en compte l'index, qui est à 0 au départ, cela écrira "Veuillez entrer la valeur 0", donc pour éviter cela on ajoute 1 à l'index)

//

//

// Exercice 7 : le nombre mystère avec boucle While
// + Exercice 8 : nettoyer console à chaque tour et afficher les nombres déjà joués par une boucle foreach
// + Exercice 9 : Try-catch pour attraper les erreurs si l'utulisateur ne saisit une bonne valeur de nombre

const int mysterious = 5;

const int numberMin = 1;
const int numberMax = 10;
// Ces 2 variables servent plus tard pour le try-catch à la vérification des erreurs.

Console.WriteLine("Quel est votre prénom ?");
string name = Console.ReadLine();
Console.WriteLine($"Bonjour {name} !");

bool victory = false;
// Il s'agit ici d'un booléen de victoire si le joueur trouve le bon chiffre. Au départ, comme l'utilisateur n'a rien tapé, il est donc sur false.

List<int> nombresJoues = new List<int>();

string indication = "";
// Ci-dessus, une variable pour garder l'indication si le chiffre est trop petit ou trop grand.

while (victory == false)
{
    Console.Clear();
    Console.Write("Nombres déjà joués : ");

    foreach(int nombre in nombresJoues)
    {
        Console.Write($" {nombre} ");
    }
    Console.WriteLine();

    Console.WriteLine(indication);

    int number = 0;
    while(number < numberMin || number > numberMax)
    {
        Console.WriteLine($"Veuillez saisir un chiffre entre {numberMin} et {numberMax}.");
        try
        {
            number = int.Parse(Console.ReadLine());
            // J'ai choisi d'encadrer la ligne que je veux tester par un try{}. Cette ligne appartient au code, donc si je ne souhaite plus tester la ligne, je dois enlever le try et les accolades, mais surtout pas la ligne ci-dessus qui appartient au déroulement du code.
        }
        catch
        {
            number = 0;
            // ici, en cas d'erreur, je remets la valeur par défaut de number sur 0
        }

    }

    
    nombresJoues.Add(number);
    // - À chaque tour de la boucle, on cleare la console.
    // - chaque tour est généré par le fait d'écrire une valeur
    // - donc tout l'affichage doit avoir lieu avant la saisie (le ReadLine) sinon ce sera clearé de la console. Voilà pourquoi tous les WriteLine se situent au-dessus du ReadLine dans ce code.
    

    // Note 1 : le Write permet de continuer à écrire sur la même ligne.
    // Note 2 : on met ensuite un WriteLine juste pour faire un saut de ligne

    if (number == mysterious)
    {
        victory = true;
        Console.WriteLine($"Bravo {name} ! Vous avez gagné !");
    }
    else{
        if (number < mysterious)
        {
            indication = "Le chiffre est trop petit.";
        }
        else if (number > mysterious)
        {
            indication = "Le chiffre est trop grand.";
        }
    }
}





