using System;

namespace ProgramacaoEstruturada.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programação Estruturada\n");

            //array de valors, com 10 posições
            int[] valores = new int[10];

            Console.WriteLine("Digite 10 valores inteiros: ");
            obtemEntradaValores(valores);

            Console.WriteLine(" ");
            bool continuar = true;
            while (continuar)
            {

                int opcao = 0; // menu
                apresentaMenu();
                switchMenu(opcao, valores);

                Console.WriteLine(" ");
                continuarPrograma(continuar);

            }
            #region metodos
            static void obtemEntradaValores(int[] valores)
            {
                int qtdValores = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Digite o valor {0} : ", qtdValores);
                    valores[i] = int.Parse(Console.ReadLine());
                    qtdValores++;
                }

            }

            static int obtemMaiorValor(int[] valores)
            {
                int maiorValor = valores[0];
                for (int j = 0; j < 10; j++)
                {
                    if (valores[j] > maiorValor)
                    {
                        maiorValor = valores[j];
                    }
                }
                return maiorValor;

            }

            static int obtemMenorValor(int[] valores)
            {
                int menorValor = valores[0];
                for (int j = 0; j < 10; j++)
                {
                    if (valores[j] < menorValor)
                    {
                        menorValor = valores[j];
                    }
                }
                return menorValor;

            }

            static string tresMaioresValores(int[] valores)
            {
                int maior1 = 0, maior2 = 0, maior3 = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (valores[i] > maior1)
                    {
                        maior1 = valores[i];
                    }

                }
                for (int j = 0; j < 10; j++)
                {
                    if (maior1 > maior2 && valores[j] != maior1)
                    {
                        if (valores[j] > maior2)
                        {
                            maior2 = valores[j];
                        }
                    }
                }
                for (int k = 0; k < 10; k++)
                {
                    if (maior2 > maior3 && valores[k] != maior1 && valores[k] != maior2)
                    {
                        if (valores[k] > maior3)
                        {
                            maior3 = valores[k];
                        }
                    }
                }
                string resultado = maior1 + " " + maior2 + " " + maior3;

                return resultado;


            }

            static void valoresNegativos(int[] valores)
            {
                Console.WriteLine("Valores negativos: ");
                int contaNegativos = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (valores[i] < 0)
                    {
                        Console.Write(valores[i] + " ");
                        contaNegativos++;
                    }
                }
                if (contaNegativos == 0)
                {
                    Console.Write("Não há valores negativos");
                }

            }

            static void mostrarValores(int[] valores)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Valores da sequência: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(valores[i] + "  ");
                }
                Console.WriteLine(" ");
            }

            static int calculaMedia(int[] valores)
            {
                int media = 0;
                int soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += valores[i];
                }
                media = soma / 10;
                return media;
            }

            static void removeItem(int[] valores)
            {
                int contaPosicao = 0;
                Console.WriteLine("\nDeseja remover o item que está em qual posição?");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("[{0}] = {1}", contaPosicao, valores[i]);
                    contaPosicao++;
                }

                Console.Write("Digite o valor da posição: ");
                int posicaoItemRemovido = int.Parse(Console.ReadLine());

                Console.WriteLine("Nova sequência: ");
                for (int i = 0; i < 10; i++)
                {
                    if (i != posicaoItemRemovido)
                    {
                        Console.Write(valores[i] + " ");
                    }
                }

            }

            static void apresentaMenu()
            {
                Console.WriteLine("" +
                    "\tOpção 1 - encontrar o maior valor\n" +
                    "\tOpção 2 - encontrar o menor valor\n" +
                    "\tOpção 3 - econtrar o valor médio da sequência\n" +
                    "\tOpção 4 - encontrar os 3 maiores valores da sequência\n" +
                    "\tOpção 5 - encontrar os valores negativos da sequência\n" +
                    "\tOpção 6 - vizualizar todos os valores da sequência\n" +
                    "\tOpção 7 - remover um item da sequência");
            }

            static int obtemOpcaoMenu(int opcao)
            {
                Console.Write("\n\tEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                return opcao;
            }

            static void switchMenu(int opcao, int[] valores)
            {
                switch (obtemOpcaoMenu(opcao))
                {
                    case 1:
                        Console.WriteLine("Maior valor: {0}", obtemMaiorValor(valores));
                        break;
                    case 2:
                        Console.WriteLine("Menor valor: {0}", obtemMenorValor(valores));
                        break;
                    case 3:
                        Console.WriteLine("Média aritmética: {0}", calculaMedia(valores));
                        break;
                    case 4:
                        Console.WriteLine("Três maiores valores: {0}", tresMaioresValores(valores));
                        break;
                    case 5:
                        valoresNegativos(valores);
                        break;
                    case 6:
                        mostrarValores(valores);
                        break;
                    case 7:
                        removeItem(valores);
                        break;
                }

            }

            static bool continuarPrograma(bool continuar)
            {
                Console.WriteLine("");
                Console.WriteLine("Deseja realizar outro comando? \n1 = sim, 0 = sair");
                char rContinuar = char.Parse(Console.ReadLine());

                while (rContinuar != '1' && rContinuar != '0')
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Deseja realizar outro comando? \n1 = sim, 0 = sair");
                     rContinuar = char.Parse(Console.ReadLine());
                }

                if (rContinuar == '1')
                {
                    Console.Clear();
                    continuar = true;
                }
                else if (rContinuar == '0')
                {
                    continuar = false;
                }

                return continuar;
            }
            #endregion;
        }
    }
}
