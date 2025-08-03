// Aluno: Wasgton Gomes Pereira
//Professor: Jefferson A. dos Santos

//------------ALGORITMOS E LÓGICA DE PROGRAMAÇÃO--------------


//1. Faça um algoritmo para ler três valores reais e informar se estes podem ou não formar os lados
//de um triângulo, e se formar, qual tipo de triângulo seria: equilátero, isósceles ou escaleno.

{

int lado1, lado2, lado3;

escreva(" Insira o valor do 1º lado do triângulo: ");
leia(lado1);

escreva(" Insira o valor do 2º lado do triângulo: ");
leia(lado2);

escreva(" Insira o valor do 3º lado do triângulo: ");
leia(lado3);

if ((lado1<(lado2+lado3)) && (lado2<(lado1+lado3)) && (lado3<(lado1+lado2)))
{
	if ((lado1==lado2) && (lado2==lado3))
	{
		escreva("Os três valores informados formam o triângulo do tipo equilátero");
	}
	else
	{
			if((lado1==lado2)|| (lado1==lado3)|| (lado2==lado3))
			{
				escreva("Os três valores informados formam o triângulo do tipo isósceles");

			}
			else
			{
				
				escreva("Os três valores informados formam o triângulo do tipo escaleno");

			}
	}
}
else
{
	escreva("Os valores informados não podem formar um Triângulo!!");
}

}



//2. Elabore um algoritmo que indique se um número digitado está compreendido entre -50 e 180, ou
//não.


{

int valor;

escreva("Informe um valor para realiazar a verificação:");
leia(valor);

if((valor >= -50) && (valor <= 180))
{
	escreva(" O valor informado está compreendido entre o intervalo de -50 e 180");
}
else
{
	escreva("O valor informado não está compreendido entre o intervalo  de -50 e 180");
}
	
}


//3. Considere que o último concurso vestibular apresentou três provas: Português, Matemática e
//Conhecimentos Gerais. Considerando que para cada candidato tem-se um registro contendo o seu
//nome e as notas obtidas em cada uma das provas, construa um algoritmo que leia o nome e as
//notas do candidato e forneça:
//a. A média do candidato
//b. Uma informação dizendo se o candidato foi aprovado ou não. Considere que um candidato
//é aprovado se sua média for maior que 6.0 e se não apresentou nenhuma nota abaixo de5.0

{

string nome;
float nota_portugues, nota_matematica, nota_conhecimentos_gerais, media;

escreva("Insira o nome do aluno:");
leia(nome);

escreva("Insira a nota referente a Português:");
leia(nota_portugues);

escreva("Isira a nota referente a Matemática";);
leia(nota_matematica);

escreva("Insira a nota referente a Conhecimentos Gerais:");
leia(nota_conhecimentos_gerais);

media= ((nota_conhecimentos_gerais + nota_matematica + nota_portugues)/3);

if ((media>=6.0) && (nota_conhecimentos_gerais>=5.0) && (nota_matematica>=5.0) && (nota_portugues>=5.0) )
{
	escreva("O aluno "+ nome + " foi APROVADO com média geral de "+ media + " e obteve nota superior que 5.0 em todas as meterias" );
}
else
{
	escreva("O aluno "+ nome + " foi REPROVADO com média geral de "+ media );

}


}

//4. Suponha que o conceito de um aluno seja determinado em função da sua nota. Suponha, também,
//que esta nota seja um valor inteiro na faixa de 0 a 100, conforme a seguinte faixa:
//Nota Conceito
//0 a 49 Insuficiente
//50 a 64 Regular
//65 a 84 Bom
//85 a 100 Ótimo
//
//Crie um algoritmo que apresente o conceito e a nota do aluno.


{

int nota_do_aluno;

escreva("Insira uma nota:");
leia(nota_do_aluno);
	
	
if((nota_do_aluno>= 0) && (nota_do_aluno<=49))
{
	escreva(" A nota "+ nota_do_aluno +" do aluno apresenta o conceito de INSUFICIENTE!!");
}
else
{
	if((nota_do_aluno>= 50) && (nota_do_aluno<=64))
	{
		escreva(" A nota "+ nota_do_aluno +" do aluno apresenta o conceito de REGULAR!!");
	}
	else
	{
		if((nota_do_aluno>= 65) && (nota_do_aluno<=84))
		{
			escreva(" A nota "+ nota_do_aluno +" do aluno apresenta o conceito de BOM!!");
		}
		else
		{
			if((nota_do_aluno>= 85) && (nota_do_aluno<=100))
			{
				escreva(" A nota "+ nota_do_aluno +" do aluno apresenta o conceito de ÓTIMO!!");
			}
			else
			{
				escreva("A nota informada não não possui um conceito, por favor verifique se a nota foi informada coretamente!!!!");
			}
		}
	}
}
	
}