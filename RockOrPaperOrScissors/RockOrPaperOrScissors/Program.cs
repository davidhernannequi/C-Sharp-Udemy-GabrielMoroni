using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        bool play = true;
        string question;

        while (play)
        {
            int userInput, systemInput, randomNumber;

            //1- take user input
            Console.WriteLine("Ingresa 1,2 o 3: \n 1.Piedra \n 2.Papel  \n 3.Tijera");
            userInput = int.Parse(Console.ReadLine());
            
            //2-Ramdomly generetes te output
            Random rndNum = new Random();
            randomNumber = rndNum.Next(1, 4);
            
            switch (randomNumber)
            {
                case 1:
                    systemInput = 1;
                    if (userInput == systemInput)
                    {
                        Console.WriteLine("Elegiste: PIEDRA \nLa computadora eligio: PIEDRA \nResultado: EMPATE");
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Elegiste: PAPEL \nLa computadora eligio: PIEDRA \nResultado: GANASTE");
                    }
                    else
                    {
                        Console.WriteLine("Elegiste: TIJERA \nLa computadora eligio: PIEDRA \nResultado: GANASTE");
                    }
                    break;

                case 2:
                    systemInput = 2;
                    if (userInput == 1)
                    {
                        Console.WriteLine("Elegiste: PIEDRA \nLa computadora eligio: PAPEL \nResultado: PERDISTE");
                    }
                    else if (userInput == systemInput)
                    {
                        Console.WriteLine("Elegiste: PAPEL \nLa computadora eligio: PAPEL \nResultado: EMPATE");
                    }
                    else
                    {
                        Console.WriteLine("Elegiste: TIJERA \nLa computadora eligio: PAPEL \nResultado: EMPATE");
                    }   
                    break;

                case 3:
                    systemInput = 3;
                    if (userInput == 1)
                    {
                        Console.WriteLine("Elegiste: PIEDRA \nLa computadora eligio: TIJERA \nResultado: GANASTE");
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Elegiste: PAPEL \nLa computadora eligio: TIJERA \nResultado: PERDISTE");
                    }
                    else 
                    {
                        Console.WriteLine("Elegiste: TIJERA \nLa computadora eligio: TIJERA \nResultado: EMPATE");
                    }
                    break;

                default:
                    Console.WriteLine("Entrada invalida! Por favor ingresa 1 (para Piedra), 2 (para Papel) o 3 (para Tijera)");
                    break;
            }

            //5- Restart the game
            Console.WriteLine("\n Queres volver a jugar: \n s(si) / n(no)");
            question = Console.ReadLine();

            if (question == "s")
            {
                continue;
            }
            else if (question == "n")
            {
                play = false;
            }
            else
            {
                Console.WriteLine("Opcion invalida! Saliendo del juego...");
                play = false;
            }

        }
    }
}