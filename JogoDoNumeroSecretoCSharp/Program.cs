﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria uma instância de Random
        Random random = new Random();

        // Gera um número aleatório entre 1 e 100 (inclusive)
        int numeroAleatorio = random.Next(1, 101);

        Console.WriteLine("Tente adivinhar o número gerado (entre 1 e 100):");

        // Loop para o jogador tentar adivinhar
        while (true)
        {
            // Lê a entrada do usuário
            Console.Write("Insira um número de 1 a 100: ");
            string respostaDoUsuario = Console.ReadLine();

            // Tenta converter a entrada para número
            if (int.TryParse(respostaDoUsuario, out int chute))
            {
                // Verifica se o número está correto
                if (chute == numeroAleatorio)
                {
                    Console.WriteLine("\nParabéns! Você acertou!");
                    break; // Encerra o jogo
                }
                else if (chute < numeroAleatorio)
                {
                    Console.WriteLine("\nO número é maior. Tente novamente!");
                }
                else
                {
                    Console.WriteLine("\nO número é menor. Tente novamente!");
                }
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, insira um número inteiro entre 1 a 100.");
            }
        }
    }
}