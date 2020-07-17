using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstProjectCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputPlayer, InputCPU;
            int scoreCPU = 0, scorePlayer = 0;
            bool loop = true;
            int keep = 1;

            while(keep == 1)
            {
                Console.Write("Pedra , Papel ou tesoura ? : ");
                InputPlayer = Console.ReadLine();
                InputPlayer = InputPlayer.ToUpper();

            
                Random rndnumber = new Random();
                int RandomCPUInput = rndnumber.Next(1, 4);

                switch (RandomCPUInput)
                {
                    case 1:
                        {
                            InputCPU = "PEDRA";
                            InputCPU = InputCPU.ToUpper();

                            if (InputCPU == InputPlayer)
                            {
                                Console.WriteLine("EMPATE !!");
                                Console.WriteLine("O computador escolheu Pedra");
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "PAPEL")
                            {
                                Console.WriteLine("GANHASTE !");
                                Console.WriteLine("O computador escolheu Pedra");
                                scorePlayer++;

                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "TESOURA")
                            {
                                Console.WriteLine("PERDEU MANO !");
                                Console.WriteLine("O computador escolheu Pedra");
                                scoreCPU++;
                                    
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }
                            break;
                        }

                    case 2:
                        {
                            InputCPU = "PAPEL";
                            InputCPU = InputCPU.ToUpper();

                            if (InputCPU == InputPlayer)
                            {
                                Console.WriteLine("EMPATE !!");
                                Console.WriteLine("O computador escolheu Papel");
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "TESOURA")
                            {
                                Console.WriteLine("GANHASTE !");
                                Console.WriteLine("O computador escolheu Papel");
                                scorePlayer++;
                                    
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "PEDRA")
                            {
                                Console.WriteLine("PERDEU MANO !");
                                Console.WriteLine("O computador escolheu Papel");
                                scoreCPU++;
                                 
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }
                            break;
                        }

                    case 3:
                        {
                            InputCPU = "TESOURA";
                            InputCPU = InputCPU.ToUpper();

                            if (InputCPU == InputPlayer)
                            {
                                Console.WriteLine("EMPATE !!");
                                Console.WriteLine("O computador escolheu Tesoura");
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "PAPEL")
                            {
                                Console.WriteLine("PERDEU MANO !");
                                Console.WriteLine("O computador escolheu Tesoura");
                                scoreCPU++;
                                                
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }

                            else if (InputPlayer == "PEDRA")
                            {
                                Console.WriteLine("GANHASTE !");
                                Console.WriteLine("O computador escolheu Tesoura");
                                scorePlayer++;
                                
                                Console.WriteLine("Sua Pontuação : " + scorePlayer + " Computador : " + scoreCPU);
                            }
                            break;                       
                        }    
                }
                Console.WriteLine("Quer continuar jogando / 1- sim / 2- nao : \n\n\n");
                keep = Convert.ToInt32(Console.ReadLine());

                if (keep == 2)
                    break;
            }
                Console.ReadKey();
        }
    }
}
