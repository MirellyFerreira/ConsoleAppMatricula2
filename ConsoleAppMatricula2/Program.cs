using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMatricula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagasDS = 5;
            int vagasADM = 5;
            int vagasMeca = 5;
            int vagasEDF = 5;

            int totalMatriculasDS = 0;
            int totalMatriculasADM = 0;
            int totalMatriculasMeca = 0;
            int totalMatriculasEDF = 0;

            Console.WriteLine("Bem-vindo ao sistema de matrícula!");

            while (true)
            {
                Console.WriteLine("Escolha um curso para se matricular:");
                Console.WriteLine("1. DS (Desenvolvimeto de Sistemas)");
                Console.WriteLine("2. ADM (Administração)");
                Console.WriteLine("3. Meca (Mecatrônica)");
                Console.WriteLine("4. EDF (Efificações)");
                Console.WriteLine("0. Encerrar matrícula");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Matrícula encerrada.");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        if (vagasDS > 0)
                        {
                            vagasDS--;
                            totalMatriculasDS++;
                            Console.WriteLine("Matrícula em DS realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para DS.");
                        }
                        break;
                    case 2:
                        if (vagasADM > 0)
                        {
                            vagasADM--;
                            totalMatriculasADM++;
                            Console.WriteLine("Matrícula em ADM realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para ADM.");
                        }
                        break;
                    case 3:
                        if (vagasMeca > 0)
                        {
                            vagasMeca--;
                            totalMatriculasMeca++;
                            Console.WriteLine("Matrícula em Meca realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para Meca.");
                        }
                        break;
                    case 4:
                        if (vagasEDF > 0)
                        {
                            vagasEDF--;
                            totalMatriculasEDF++;
                            Console.WriteLine("Matrícula em EDF realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para EDF.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            Console.WriteLine($"Total de matrículas em DS: {totalMatriculasDS}");
            Console.WriteLine($"Total de matrículas em ADM: {totalMatriculasADM}");
            Console.WriteLine($"Total de matrículas em Meca: {totalMatriculasMeca}");
            Console.WriteLine($"Total de matrículas em EDF: {totalMatriculasEDF}");
        }
    }
}
   