using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
                correct = false;
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");

                try
                {
                    choix = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie");
                    goto Beginning;
                }
                    // traitement des choix
                    switch (choix)
                {
                    case 1:
                    
                        // choix de l'addition
                     
                    // saisie de la réponse
                    case1Try:
                        Console.Write(val1 + " + " + val2 + " = ");
                    
                        try
                        {
                            reponse = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie");
                            
                            goto case1Try;
                        }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    case 2:
                    
                        // choix de la multiplication

                        // saisie de la réponse
                        case2Try:
                        Console.Write(val1 + " x " + val2 + " = ");
                        try
                        {
                            reponse = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie");

                            goto case2Try;
                        }


                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    default:
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
        }
    }
}
