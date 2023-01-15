using System;
using System.Net.Http.Headers;

namespace ExercicioFixacao {
    public class ExercicioMatriz {
        public static void Main() {
            Console.WriteLine("Digite o número de linhas da matriz:");
            int linhasMatriz = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas da matriz:");
            int colunasMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhasMatriz, colunasMatriz];

            Console.Clear();

            for(int contadorLinhas = 0; contadorLinhas < matriz.GetLength(0); contadorLinhas++) {
                for(int contadorColunas = 0; contadorColunas < matriz.GetLength(1); contadorColunas++) {
                    Console.WriteLine("Digite o número da posição ["+contadorLinhas+", "+contadorColunas+"]:");
                    matriz[contadorLinhas, contadorColunas] = int.Parse(Console.ReadLine());

                    Console.Clear();
                }
            }

            Console.WriteLine("A matriz é:");

            for (int contadorLinhas = 0; contadorLinhas < matriz.GetLength(0); contadorLinhas++) {
                Console.WriteLine();

                for (int contadorColunas = 0; contadorColunas < matriz.GetLength(1); contadorColunas++) {
                    Console.Write(matriz[contadorLinhas, contadorColunas]+" ");
                }
            }

            Console.WriteLine();

            int numeroWhile = 0;

            int numeroMatriz = 0;

            while (numeroWhile<1) {
                Console.WriteLine("Digite um número que está dentro da matriz para verificar os valores abaixo, acima, a esquerda e a direita deste valor");
                numeroMatriz = int.Parse(Console.ReadLine());

                for (int contadorLinhas = 0; contadorLinhas < matriz.GetLength(0); contadorLinhas++) {
                    for (int contadorColunas = 0; contadorColunas < matriz.GetLength(1); contadorColunas++) {
                        if (matriz[contadorLinhas, contadorColunas] == numeroMatriz) {
                            numeroWhile++;
                        }
                    }
                }

                if (numeroWhile == 0) {
                    Console.Clear();

                    Console.WriteLine("O número digitado não corresponde a nenhum número da matriz.");

                }
            }

            MostrarValor(matriz, numeroMatriz);
        }
        public static void MostrarValor(int[,] matriz, int numero) {
            for (int contadorLinha = 0; contadorLinha < matriz.GetLength(0); contadorLinha++) {
                for (int contadorColuna = 0; contadorColuna < matriz.GetLength(1); contadorColuna++) {
                    if (matriz[contadorLinha, contadorColuna] == numero) {
                        Console.WriteLine("Posição: ["+contadorLinha+", "+contadorColuna+"]");

                        if ((contadorColuna - 1) < matriz.GetLength(1) && (contadorColuna - 1) >= 0) {
                            Console.WriteLine("Valor a esquerda de " + numero + " é: " + matriz[contadorLinha, (contadorColuna - 1)]);
                        }

                        if ((contadorLinha - 1) < matriz.GetLength(0) && (contadorLinha - 1) >= 0) {
                            Console.WriteLine("Valor acima de " + numero + " é: " + matriz[(contadorLinha - 1), contadorColuna]);
                        }

                        if ((contadorLinha + 1) < matriz.GetLength(0) && (contadorLinha + 1) >= 0) {
                            Console.WriteLine("Valor abaixo de " + numero + " é: " + matriz[(contadorLinha + 1), contadorColuna]);
                        }

                        if ((contadorColuna + 1) < matriz.GetLength(1) && (contadorColuna + 1) >= 0) {
                            Console.WriteLine("Valor a direita de " + numero + " é: " + matriz[contadorLinha, (contadorColuna + 1)]);
                        }

                    }
                }
            }
        }
    }
}