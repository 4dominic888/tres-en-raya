using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            //Objetivo: Crear un tres en raya
            Console.WriteLine("Jugador 1\n¿Quieres usar las X o las O?\n[1]: X\n[2]: O");

            string jugador_X = " ";
            string jugador_O = " ";

            int x_o = int.Parse(Console.ReadLine());
            if (x_o == 1) Jugador1_X(jugador_X, jugador_O); //Para cuando el primer jugador elija X
            else if (x_o == 2) Jugador1_O(jugador_X, jugador_O); //Para cuando el primer jugador elija O
            else
            {
                Console.WriteLine("Ingrese un número válido");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        static void Jugador1_X(string jugador_X, string jugador_O)
        {
            Console.Clear();

            //variables

            jugador_X = "jugador 1";
            jugador_O = "jugador 2";

            String casilla1 = " ";
            String casilla2 = " ";
            String casilla3 = " ";
            String casilla4 = " ";
            String casilla5 = " ";
            String casilla6 = " ";
            String casilla7 = " ";
            String casilla8 = " ";
            String casilla9 = " ";

            int contador_x1 = 0;
            int contador_x2 = 0;
            int contador_x3 = 0;
            int contador_x4 = 0;
            int contador_x5 = 0;
            int contador_x6 = 0;
            int contador_x7 = 0;
            int contador_x8 = 0;
            int contador_x9 = 0;

            int contador_O1 = 0;
            int contador_O2 = 0;
            int contador_O3 = 0;
            int contador_O4 = 0;
            int contador_O5 = 0;
            int contador_O6 = 0;
            int contador_O7 = 0;
            int contador_O8 = 0;
            int contador_O9 = 0;



            do
            {
                Console.WriteLine($"{jugador_X}\nIngrese la casilla que desea colocar\n\nCasillas:");
                Console.WriteLine($" 1 | 2 | 3 ");
                Console.WriteLine($" 4 | 5 | 6 ");
                Console.WriteLine($" 7 | 8 | 9 ");
                Console.WriteLine("\n");
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");

                int colocar1 = int.Parse(Console.ReadLine());
                switch (colocar1) //Comando para colocar las x
                {
                    case 1:
                        if (contador_x1 == 0 && contador_O1 == 0) casilla1 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x1 = 2;
                        break;

                    case 2:
                        if (contador_x2 == 0 && contador_O2 == 0) casilla2 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x2 = 2;
                        break;

                    case 3:
                        if (contador_x3 == 0 && contador_O3 == 0) casilla3 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x3 = 2;
                        break;

                    case 4:
                        if (contador_x4 == 0 && contador_O4 == 0) casilla4 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x4 = 2;
                        break;

                    case 5:
                        if (contador_x5 == 0 && contador_O5 == 0) casilla5 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x5 = 2;
                        break;

                    case 6:
                        if (contador_x6 == 0 && contador_O6 == 0) casilla6 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x6 = 2;
                        break;

                    case 7:
                        if (contador_x7 == 0 && contador_O7 == 0) casilla7 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x7 = 2;
                        break;

                    case 8:
                        if (contador_x8 == 0 && contador_O8 == 0) casilla8 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x8 = 2;
                        break;

                    case 9:
                        if (contador_x9 == 0 && contador_O9 == 0) casilla9 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_x9 = 2;
                        break;

                    default:
                        Console.WriteLine("ingrese un valor válido");
                        Console.ReadKey();
                        Jugador1_X(jugador_X, jugador_O);
                        break;
                }

                //condición para ganar en las X

                Ganar_X(casilla1 , casilla2, casilla3, casilla4, casilla5, casilla6, casilla7, casilla8, casilla9, jugador_X);

                Console.Clear();


                Console.WriteLine($"{jugador_O}\nIngrese la casilla que desea colocar\n\nCasillas:");
                Console.WriteLine($" 1 | 2 | 3 ");
                Console.WriteLine($" 4 | 5 | 6 ");
                Console.WriteLine($" 7 | 8 | 9 ");
                Console.WriteLine("\n");
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");

                int colocar2 = int.Parse(Console.ReadLine());
                switch (colocar2)
                {
                    case 1:
                        if (contador_O1 == 0 && contador_x1 == 0) casilla1 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O1 = 2;
                        break;

                    case 2:
                        if (contador_O2 == 0 && contador_x2 == 0) casilla2 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O2 = 2;
                        break;

                    case 3:
                        if (contador_O3 == 0 && contador_x3 == 0) casilla3 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O3 = 2;
                        break;

                    case 4:
                        if (contador_O4 == 0 && contador_x4 == 0) casilla4 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O4 = 2;
                        break;

                    case 5:
                        if (contador_O5 == 0 && contador_x5 == 0) casilla5 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O5 = 2;
                        break;

                    case 6:
                        if (contador_O6 == 0 && contador_x6 == 0) casilla6 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O6 = 2;
                        break;

                    case 7:
                        if (contador_O7 == 0 && contador_x7 == 0) casilla7 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O7 = 2;
                        break;

                    case 8:
                        if (contador_O8 == 0 && contador_x8 == 0) casilla8 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O8 = 2;
                        break;

                    case 9:
                        if (contador_O9 == 0 && contador_x9 == 0) casilla9 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_X(jugador_X, jugador_O);
                        }
                        contador_O9 = 2;
                        break;

                    default:
                        Console.WriteLine("ingrese un valor válido\nel código se reiniciará");
                        Console.ReadKey();
                        Jugador1_X(jugador_X, jugador_O);
                        break;
                }
                //condicion para ganar O
                Ganar_O(casilla1, casilla2, casilla3, casilla4, casilla5, casilla6, casilla7, casilla8, casilla9, jugador_O);
                Console.Clear();

            } while (true);


        }


        static void Jugador1_O(string jugador_X, string jugador_O)
        {
            Console.Clear();

            //variables

            jugador_X = "jugador 2";
            jugador_O = "jugador 1";

            String casilla1 = " ";
            String casilla2 = " ";
            String casilla3 = " ";
            String casilla4 = " ";
            String casilla5 = " ";
            String casilla6 = " ";
            String casilla7 = " ";
            String casilla8 = " ";
            String casilla9 = " ";

            int contador_x1 = 0;
            int contador_x2 = 0;
            int contador_x3 = 0;
            int contador_x4 = 0;
            int contador_x5 = 0;
            int contador_x6 = 0;
            int contador_x7 = 0;
            int contador_x8 = 0;
            int contador_x9 = 0;

            int contador_O1 = 0;
            int contador_O2 = 0;
            int contador_O3 = 0;
            int contador_O4 = 0;
            int contador_O5 = 0;
            int contador_O6 = 0;
            int contador_O7 = 0;
            int contador_O8 = 0;
            int contador_O9 = 0;



            do
            {
                Console.WriteLine($"{jugador_O}\nIngrese la casilla que desea colocar\n\nCasillas:");
                Console.WriteLine($" 1 | 2 | 3 ");
                Console.WriteLine($" 4 | 5 | 6 ");
                Console.WriteLine($" 7 | 8 | 9 ");
                Console.WriteLine("\n");
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");

                int colocar1 = int.Parse(Console.ReadLine());
                switch (colocar1) //Comando para colocar las O
                {
                    case 1:
                        if (contador_O1 == 0 && contador_x1 == 0) casilla1 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O1 = 2;
                        break;

                    case 2:
                        if (contador_O2 == 0 && contador_x2 == 0) casilla2 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O2 = 2;
                        break;

                    case 3:
                        if (contador_O3 == 0 && contador_x3 == 0) casilla3 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O3 = 2;
                        break;

                    case 4:
                        if (contador_O4 == 0 && contador_x4 == 0) casilla4 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O4 = 2;
                        break;

                    case 5:
                        if (contador_O5 == 0 && contador_x5 == 0) casilla5 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O5 = 2;
                        break;

                    case 6:
                        if (contador_O6 == 0 && contador_x6 == 0) casilla6 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O6 = 2;
                        break;

                    case 7:
                        if (contador_O7 == 0 && contador_x7 == 0) casilla7 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O7 = 2;
                        break;

                    case 8:
                        if (contador_O8 == 0 && contador_x8 == 0) casilla8 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O8 = 2;
                        break;

                    case 9:
                        if (contador_O9 == 0 && contador_x9 == 0) casilla9 = "O";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la O en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_O9 = 2;
                        break;

                    default:
                        Console.WriteLine("ingrese un valor válido");
                        Console.ReadKey();
                        Jugador1_O(jugador_X, jugador_O);
                        break;
                }

                //condición para ganar en las X

                Ganar_O(casilla1, casilla2, casilla3, casilla4, casilla5, casilla6, casilla7, casilla8, casilla9, jugador_O);

                Console.Clear();


                Console.WriteLine($"{jugador_X}\nIngrese la casilla que desea colocar\n\nCasillas:");
                Console.WriteLine($" 1 | 2 | 3 ");
                Console.WriteLine($" 4 | 5 | 6 ");
                Console.WriteLine($" 7 | 8 | 9 ");
                Console.WriteLine("\n");
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");

                int colocar2 = int.Parse(Console.ReadLine());
                switch (colocar2)
                {
                    case 1:
                        if (contador_x1 == 0 && contador_O1 == 0) casilla1 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x1 = 2;
                        break;

                    case 2:
                        if (contador_x2 == 0 && contador_O2 == 0) casilla2 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x2 = 2;
                        break;

                    case 3:
                        if (contador_x3 == 0 && contador_O3 == 0) casilla3 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x3 = 2;
                        break;

                    case 4:
                        if (contador_x4 == 0 && contador_O4 == 0) casilla4 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la x en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x4 = 2;
                        break;

                    case 5:
                        if (contador_x5 == 0 && contador_O5 == 0) casilla5 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x5 = 2;
                        break;

                    case 6:
                        if (contador_x6 == 0 && contador_O6 == 0) casilla6 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x6 = 2;
                        break;

                    case 7:
                        if (contador_x7 == 0 && contador_O7 == 0) casilla7 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x7 = 2;
                        break;

                    case 8:
                        if (contador_x8 == 0 && contador_O8 == 0) casilla8 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x8 = 2;
                        break;

                    case 9:
                        if (contador_x9 == 0 && contador_O9 == 0) casilla9 = "X";
                        else
                        {
                            Console.WriteLine("no puedes volver a colocar la X en la misma posición\nel código se reiniciará");
                            Console.ReadKey();
                            Jugador1_O(jugador_X, jugador_O);
                        }
                        contador_x9 = 2;
                        break;

                    default:
                        Console.WriteLine("ingrese un valor válido\nel código se reiniciará");
                        Console.ReadKey();
                        Jugador1_O(jugador_X, jugador_O);
                        break;
                }
                //condicion para ganar O
                Ganar_X(casilla1, casilla2, casilla3, casilla4, casilla5, casilla6, casilla7, casilla8, casilla9, jugador_X);
                Console.Clear();

            } while (true);


        }


        static void Ganar_X(string casilla1, string casilla2, string casilla3, string casilla4, string casilla5, string casilla6, string casilla7, string casilla8, string casilla9, string jugador_X)
        {
            if (

                   (casilla1 == "X" && casilla2 == "X" && casilla3 == "X") == true ||
                   (casilla4 == "X" && casilla5 == "X" && casilla6 == "X") == true ||  // horizontal
                   (casilla7 == "X" && casilla8 == "X" && casilla9 == "X") == true ||

                   (casilla1 == "X" && casilla4 == "X" && casilla7 == "X") == true ||
                   (casilla2 == "X" && casilla5 == "X" && casilla8 == "X") == true ||  // vertical
                   (casilla3 == "X" && casilla6 == "X" && casilla9 == "X") == true ||

                   (casilla1 == "X" && casilla5 == "X" && casilla9 == "X") == true ||  // diagonal
                   (casilla7 == "X" && casilla5 == "X" && casilla3 == "X") == true

                   )
            {
                Console.Clear();
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");
                Console.WriteLine($"\n{jugador_X} Gana");
                Console.ReadKey();
                Console.Clear();
                Main();
            }


        }

        static void Ganar_O(string casilla1, string casilla2, string casilla3, string casilla4, string casilla5, string casilla6, string casilla7, string casilla8, string casilla9, string jugador_O)
        {
            if (
                   (casilla1 == "O" && casilla2 == "O" && casilla3 == "O") == true ||
                   (casilla4 == "O" && casilla5 == "O" && casilla6 == "O") == true ||  // horizontal
                   (casilla7 == "O" && casilla8 == "O" && casilla9 == "O") == true ||

                   (casilla1 == "O" && casilla4 == "O" && casilla7 == "O") == true ||
                   (casilla2 == "O" && casilla5 == "O" && casilla8 == "O") == true ||  // vertical
                   (casilla3 == "O" && casilla6 == "O" && casilla9 == "O") == true ||

                   (casilla1 == "O" && casilla5 == "O" && casilla9 == "O") == true ||  // diagonal
                   (casilla7 == "O" && casilla5 == "O" && casilla3 == "O") == true

                   )
            {
                Console.Clear();
                Console.WriteLine($" {casilla1} | {casilla2} | {casilla3} ");
                Console.WriteLine($" {casilla4} | {casilla5} | {casilla6} ");
                Console.WriteLine($" {casilla7} | {casilla8} | {casilla9} ");
                Console.WriteLine($"\n{jugador_O} Gana");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }

        }
}