using System;

namespace AtividadeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thalys Alves Braga");
            Console.WriteLine("");

            int comandoMenu = 1;
            do
            {
                Console.WriteLine("      MENU:    ");
                Console.WriteLine("1 - Exercicio 1");
                Console.WriteLine("2 - Exercicio 2");
                Console.WriteLine("3 - Exercicio 3");
                Console.WriteLine("4 - Exercicio 4");
                Console.WriteLine("5 - Exercicio 5");
                Console.WriteLine("6 - Exercicio 6");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");


                comandoMenu = int.Parse(Console.ReadLine());
                switch (comandoMenu)
                {
                    case 0:
                        Console.WriteLine("Pressione qualquer tecla para sair:");
                        break;
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 1");
                        Exercicio1();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 2");
                        Exercicio2();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 3");
                        Exercicio3();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 4");
                        Exercicio4();
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 5");
                        Exercicio5();
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Exercicio 6");
                        Exercicio6();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
                        break;
                }
            } while (comandoMenu != 0);

            Console.ReadKey();
        }
        private static void Exercicio1()
        {
            int resultado = 0;
            for (int i = 0; i <= 100; i++)
            {
                resultado = resultado + i;
            }
            Console.WriteLine("A soma de 1 a 100 é de " + resultado);
            Console.WriteLine("");
        }
        private static void Exercicio2()
        {
            int positivos, somaPositivos = 0, contadorNegativos = 0, separador;
            Console.WriteLine("Digite 50 valores inteiros");
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("Digite o " + i +"º valor: ");
                separador = int.Parse(Console.ReadLine());
                if (separador > 0)
                {
                    positivos = separador;
                    somaPositivos = somaPositivos + positivos;
                }
                if (separador < 0)
                {
                    contadorNegativos++;
                }
            }
            Console.WriteLine("A soma dos valores positivos foi de: " + somaPositivos);
            Console.WriteLine("A quantidade de valores negativos foi de: " + contadorNegativos);
            Console.WriteLine("");
        }
        private static void Exercicio3()
        {
            int contador = 0;
            for (int i = 1;  i<= 1999; i++)
            {
                if (i % 11 == 5)
                {
                    Console.Write(i + "  ");
                    contador++; //Contador pra ficar diferenciado
                }
            }
            Console.WriteLine("");
            Console.WriteLine("A quantidade de valores entre 1 e 1999 divididos por 11 que tem resto 5 é de: " + contador);
            Console.WriteLine("");
        }
        private static void Exercicio4()
        {
            int pares, impares, somaPares = 0, somaImpares = 0, separador;
            do
            {
                Console.Write("Digite um valor positivo: ");
                separador = int.Parse(Console.ReadLine());
                if (separador <= 1000)
                {
                    if (separador < 0)
                    {
                        Console.WriteLine("Digite um número válido!!");
                    }
                    else
                    {
                        if (separador % 2 == 0)
                        {
                            pares = separador;
                            somaPares = somaPares + pares;
                        }
                        else
                        {
                            impares = separador;
                            somaImpares = somaImpares + impares;
                        }
                    }
                }
                
            } while (separador <= 1000);
            Console.WriteLine("A soma dos números pares foi de: " + somaPares);
            Console.WriteLine("A soma dos números ímpares foi de: " + somaImpares);
            Console.WriteLine("");
        }
        private static void Exercicio5()
        {
            int mediaIdade = 0 ,mediaAltura = 0, idade, altura, contIdade = 0, contAltura = 0, somaIdade = 0, somaAltura = 0;
            for (int i = 1; i <= 45; i++)
            {
                Console.Write("Digite a idade do " + i + "º aluno: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Digite a altura(em CM) do "+ i + "º aluno: ");
                altura = int.Parse(Console.ReadLine());

                if (altura < 160)
                {
                    somaIdade = somaIdade + idade;
                    contIdade++;
                }
                if (idade > 18)
                {
                    somaAltura = somaAltura + altura;
                    contAltura++;
                }
            }
            if (contIdade != 0)
            {
                mediaIdade = somaIdade / contIdade;
                Console.WriteLine("A idade média dos alunos com menos de 1,60 é de: " + mediaIdade);
            }
            else
            {
                Console.WriteLine("Não há alunos com menos de 1,60 de altura!");
            }
            if (contAltura != 0)
            {
                mediaAltura = somaAltura / contAltura;
                Console.WriteLine("A altura média dos alunos com mais de 18 anos é de: " + mediaAltura);
            }
            else
            {
                Console.WriteLine("Não há alunos com mais de 18 anos de idade!");
            }
        }
        private static void Exercicio6()
        {
            string sexo, corOlhos, corCabelo;
            int idade, idadeMaior = 0, contOlhosVerdesCabeloLoiro = 0, contFeminino2030 = 0, sair;

            do
            {
                Console.Write("Digite o sexo: M ou F: ");
                sexo = Console.ReadLine();           
                Console.Write("Digite a cor dos olhos: Azuis, Verdes ou Castanhos: ");
                corOlhos = Console.ReadLine();
                Console.Write("Digite a cor do cabelo: Louros, Castanhos ou Pretos: ");
                corCabelo = Console.ReadLine();
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade > idadeMaior)
                {
                    idadeMaior = idade;
                }
                if (sexo == "F" && idade >= 20 && idade <= 30)
                {
                    contFeminino2030++;
                }
                if (corOlhos == "Verdes" && corCabelo == "Louros")
                {
                    contOlhosVerdesCabeloLoiro++;
                }

                Console.WriteLine("");
                Console.WriteLine("Número negativo - Terminar registros");
                Console.WriteLine("Número positivo - Adicionar um novo registro à pesquisa");
                Console.WriteLine("");
                sair = int.Parse(Console.ReadLine());
            } while (sair >= 0);

            Console.WriteLine("A Maior idade é de: " + idadeMaior + " anos.");
            Console.WriteLine("A quantidade de indivíduos do sexo feminino com idade entre 30 e 40 anos é de " + contFeminino2030 + " indivíduos");
            Console.WriteLine("A quantidade de indivíduos com olhos verdes e cabelos louros é de " + contOlhosVerdesCabeloLoiro + " indivíduos.");
        }
    }
}
