//ACELERA.NET 2023/24
//MÓDULO 8 - Programação em C#
//Professor: Flavio Siqueira - flaviosiqueira@outlook.com

// A aplicação console abaixo implementa:
// Tipos de Variáveis: Int, String, Char, Double, Double[]
// Estrutura de decisão
// Estrutura condicional
// Funções de Escrita e Leitura em Console
// Funções/Métodos com e sem parametros

///////////////////////////////////////////////////////
//--------------------NECESSÁRIO---------------------//
//-----***IMPLEMENTAR LAÇO FOR E WHILE/DO WHILE------//
///////////////////////////////////////////////////////

#region Variáveis internas 
int opcao;
string repetir = "n";
double Magreza = 18.5;
double Normal = 24.9;
double Sobrepeso = 29.9;
double Obesidade = 39.9;
double ObesidadeGrave = 40;
#endregion

do
{
    Console.WriteLine("***********************************************\n"+
                      "**        CALCULADORA MEGA ULTRA 2.0         **\n"+
                      "***********************************************\n"+
                      "**   Seja bem vindos amigos do ACELERA.NET   **\n"+
                      "***********************************************\n\n"+
                      "Escolha o calculo que deseja:\n\n"+
                      "1 - CALCULAR MÉDIA DE NOTAS\n"+
                      "2 - CALCULAR IMC\n\n"+
                      "Opção: \n");
    opcao = (Convert.ToInt32(Console.ReadLine()));

    switch (opcao)
    {
        case 1:
            calculaMedia();
            break;
        case 2:
            calculaIMC();
            break;
    }
    Console.Write("Deseja fazer outro cálculo? (S/N)");
    repetir = Console.ReadLine().ToLower();
    Console.Clear();
} while (repetir == "s");

Console.Write("Obrigado por usar o programa de calculadoras");


void calculaIMC()
{
    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o peso (kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a altura (cm): ");
    double altura = (Convert.ToDouble(Console.ReadLine()) / 100);

    Console.Write("Digite a idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    double IMC = 0;

    //***CALCULE O IMC DA PESSOA, UTILIZANDO A FÓRMULA...
    //IMC = PESO / ALTURA² (Altura em metros) 
    IMC = peso / (Math.Pow(altura, 2));

    Console.WriteLine("");
    Console.WriteLine($"O IMC de {nome} é: " + IMC);

    Console.WriteLine("Classificação: " + classificaIMC(IMC));
}

string classificaIMC(double iMC)
{
    return
         (iMC < Magreza) ? "Magreza" :
         (iMC < Normal) ? "Normal" :
         (iMC < Sobrepeso) ? "Sobrepeso " :
         (iMC < Obesidade) ? "Obesidade" :
         (iMC < ObesidadeGrave) ? "Obesidade Grave" : "erro na validação";

    //***IMPLEMENTE A CLASSIFICAÇÃO DE ACORDO COM O IMC
    //MENOR QUE 18,5    = MAGREZA
    //ENTRE 18,5 E 24,9 = NORMAL
    //ENTRE 25,0 E 29,9 = SOBREPESO
    //ENTRE 30,0 E 39,9 = OBESIDADE
    //MAIOR QUE 40,0    = OBESIDADE GRAVE

}

void calculaMedia()
{
    double[] notas = new double[3];
    Console.WriteLine("Digite a primeira nota:");
    notas[0] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota:");
    notas[1] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota:");
    notas[2] = Convert.ToDouble(Console.ReadLine());

    double somaDeNotas = 0;

    foreach (var nota in notas)
    {
        somaDeNotas += nota;
    }
    double media = somaDeNotas / notas.Length;

    Console.WriteLine("Aluno " + verificaAprovacao(media));
    Console.WriteLine("Média: " + media);
}

string verificaAprovacao(double media)
{
    return 
        (media < 5) ? "REPROVADO" :
        (media < 7) ? "EM RECUPERAÇÃO" : "APROVADO";
}



//***IMPLEMENTE UM RETORNO AO INICIO DA CALCULADORA SE O USUARIO DESEJA FAZER UM NOVO CALCULO
//***OU UMA MSG DE DESPEDIDA CASO ELE NÃO QUEIRA CALCULAR NOVAMENTE