using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Ex1()
        {
            int[] n;
            int t, mn, mnn, nn;
            float s, m;
            t = 0;
            s = 0;

            Console.WriteLine("Digite o tamanho do vetor. ");
            t = int.Parse(Console.ReadLine());

            n = new int[t];

            Console.WriteLine("Digite um numero. ");
            nn = int.Parse(Console.ReadLine());
            
            n[0] = nn;
            mn = nn;
            mnn = nn;

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite um numero. ");
                n[i] = int.Parse(Console.ReadLine());

                if (n[i] > mn)
                {
                    mn = n[i];
                }
                if (n[i] < mnn)
                {
                    mnn = n[i];
                }
            }

            for (int i = 0; i < t; i++)
            {
                s += n[i];
            }

            m = s / t;

            Console.WriteLine("O maior número do vetor é " + mn + ", o menor número do vetor é " + mnn + " e a média entre os valores do vetor é " + m);
            Console.ReadKey();
        }

        public static void Ex2()
        {
            int[] n;
            int t, m, s  = 0;

            Console.WriteLine("Digite o tamanho do vetor. Note que esse valor precisa ser maior que 0. ");
            t = int.Parse(Console.ReadLine());

            n = new int[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite um numero. ");
                n[i] = int.Parse(Console.ReadLine());
                s = s + n[i];
            }
            m = s / t;

            for (int i = 0; i < t; i++)
            {
                if (n[i] >= m)
                {
                    Console.WriteLine("Os numeros maiores ou iguais que a média são: " + n[i]);
                }

            }
        }

        public static void Ex3()
        {

            int[] n;
            int t, m, s = 0;

            Console.WriteLine("Digite o tamanho do vetor. Note que esse valor precisa ser maior que 0. ");
            t = int.Parse(Console.ReadLine());
            
            n = new int[t];
            Random r = new Random();

            for (int i = 0; i < t; i++)
            {
                n[i] = r.Next(1, 50);
                s = s + n[i];
            }
            m = s / t;

            for (int i = 0; i < t; i++)
            {
                if (n[i] >= m)
                {
                    Console.WriteLine("Os numeros maiores ou iguais que a média são: " + n[i]);
                }

            }
        }

        public static void Ex4()
        {
            string[] v;
            int q;

            Console.WriteLine("Digite a quantidade de nomes na lista. ");
            q = int.Parse(Console.ReadLine());

            v = new string[q];

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("Digite os nomes, respectivamente um ao outro. ");
                v[i] = Console.ReadLine();
            }

            for (int i = q - 1; i >= 0; i--)
            {
                Console.WriteLine("Posicão[{0}] = {1}", i, v[i]);
            }

        }

        public static void Ex5() 
        {
            int[] n;
            int t, im = 0, p = 0;

            Console.WriteLine("Digite o tamanho do vetor. Note que esse valor precisa ser maior que 0. ");
            t = int.Parse(Console.ReadLine());

            n = new int[t];

            Random r = new Random();

            for (int i = 0; i < t; i++)
            {
                n[i] = r.Next(1, 50);
                
                if (n[i] % 2 == 0)
                {
                    p += 1;
                }
                else
                {
                    im += 1;
                }
            }

            Console.WriteLine("Número de pares: " + p + "\n");
            Console.WriteLine("Número de ímpares: " + im + "\n");

        }

        static void Main(string[] args)
        {
            int o;

            do
            {
                Console.WriteLine("Seja bem vindo à Lista 10!! escolha uma das opções:");
                Console.WriteLine("opção 1: exibir exercício 1");
                Console.WriteLine("opção 2: exibir exercício 2");
                Console.WriteLine("opção 3: exibir exercício 3");
                Console.WriteLine("opção 4: exibir exercício 4");
                Console.WriteLine("opção 5: exibir exercício 5");
                Console.WriteLine("opção 0: Sair do programa.");
                o = int.Parse(Console.ReadLine());

                switch (o)
                {
                    case 0:
                        Console.WriteLine("Obrigado pela atenção!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;

                    case 4:
                        Ex4();
                        break;

                    case 5:
                        Ex5();
                        break;

                    default:
                        Console.WriteLine("opção indisponível.");
                        break;
                }
            }
            while (o != 0);

        }

    }
}
