using System;

namespace TrilhaEspec_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int x = 0;
            int numPesquisado = 0;
            int[] listaNumeros = new int[10];
            string msgResposta = null;

            Console.WriteLine("GRAVANDO A LISTA DE NÚMEROS");
            for (int i = 0; i < 10; i++)
            {
                //Obtém uma lista com 10 números inseridos pelo usuário.
                Console.WriteLine("Insira o " + (i+1) + "º número (apenas números inteiros):");
                while(!int.TryParse(Console.ReadLine(), out x)) 
                {
                    Console.WriteLine("Insira apenas números inteiros.");
                    Console.WriteLine("Insira o " + (i+1) + "º Valor:");
                }
                listaNumeros[i] = x;
                x = 0;    
            }

            Console.WriteLine("Digite o número que deseja buscar dentro da lista (apenas números inteiros):");
            while(!int.TryParse(Console.ReadLine(), out numPesquisado)) 
                {
                    Console.WriteLine("Insira apenas números inteiros.");
                }
            
            for (int i = 0; i < listaNumeros.Length; i++) 
            {
                //Busca na lista de número, o valor digitado pelo usuário.
                if (numPesquisado == listaNumeros[i])
                {
                    msgResposta = "O número " +  numPesquisado + " foi encontrado com sucesso! Este número é " + (numPesquisado % 2 == 0 ? "par." : "ímpar.");
                    break; 
                }   
                else
                {
                    msgResposta = "O número " + numPesquisado + " não foi encontrado.";                    
                }
            }
            Console.WriteLine(msgResposta);            
        }        
    }
}
