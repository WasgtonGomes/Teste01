// Aluno: Wasgton Gomes Pereira
//Professor: Jefferson A. dos Santos

//------------ALGORITMOS E LÓGICA DE PROGRAMAÇÃO--------------


//Faça os exercícios abaixo usando a estrutura ESCOLHA-CASO.
//1. Faça um Algoritmo para identificar quantos dias há em um mês, sabendo o mês e o ano.


exercicio_1{
	
	funcao_dias_do_mes(){
		
		int mes, ano;
		float tipo_ano;
		
		escreva("Escolha um mês do ano de 01 a 12 paraa ser consultado:");
		leia(mes);
		
		escreva("Insira o ano para realizar o procedimento de contagem dos dias:");
		leia(ano);
	
		tipo_ano = (ano % 4);
		
		escolha(mes)
		
		{
			caso 01:
				escreva("O mês de Janeiro de " + ano + " possui 31 dias");
			
				pare
			
			caso 02:
			
				if(tipo_ano==0)
				{	
					escreva("O mês de Fevereiro de " + ano + " possui 29 dias");
				}
				else
				{
			
					escreva("O mês de Fevereiro de " + ano + " possui 28 dias");
				}
			
				pare
				
			caso 03:
				escreva("O mês de Março de " + ano + " possui 31 dias");
				
				pare
				
			caso 04:
			
				escreva("O mês de Abril de " + ano + " possui 30 dias");
				
				pare
				
			caso 05:
				
				escreva("O mês de Maio de " + ano + " possui 31 dias");
				
				pare
				
			caso 06:
			
				escreva("O mês de Junho de " + ano + " possui 30 dias");
				
				pare
				
			caso 07: 
			
				escreva("O mês de Julho de " + ano + " possui 31 dias");
				
				pare
				
			caso 08:
			
				
				escreva("O mês de Agosto de " + ano + " possui 31 dias");
				
				pare
				
			caso 09:
			
				escreva("O mês de Setembro de " + ano + " possui 30 dias");
				
				pare
			
			caso 10:
			
				
				escreva("O mês de Outubro de " + ano + " possui 31 dias");
				
				pare
				
			caso 11:
			
				
				escreva("O mês de Novembro de " + ano + " possui 30 dias");
				
				pare
				
			caso 12:
			
				
				escreva("O mês de Dezembro de " + ano + " possui 31 dias");
				
				pare
				
			caso contrario:
			
				escreva("Opção invalida, por favor isira outra opção valida!!");
			pare
		}		
		
	}
}

//2. Criar um programa para identificar o valor a ser pago por um plano de saúde dada a idade do
//conveniado considerando que todos pagam R$ 600,00 mais um adicional conforme a seguinte
//tabela: 1) crianças com menos de 10 anos pagam R$90; 2) conveniados com idade entre 10 e 30
//anos pagam R$120; 3) conveniados com idade entre 40 e 60 anos pagam R$ 150; e 4) conveniados
//com mais de 60 anos pagam R$190.


exercicio_2{

	plano_de_saude(){
		
	int opcao_idade;
	float valor_a_pagar_final;
	
	
	escreva("Insira  a opção correspondente a sua idade para realizar a consulta do valor do seu plano de saúde atual: 01 para menores de 10anos; 02 entre 10 e 30 anos; 04 entre 40 e 60 anos; 04acima de 60 anos :");
	lei(opcao_idade);


		escolha(opcao_idade)
	
		{
		
		caso 01:
		
			valor_a_pagar_final= (600+90);
			
				escreva("O valor atual do seu plano de saúde é de R$ " + valor_a_pagar_final + " de acordo com a opção selecionada.");
			
			pare
			
		caso 02:
		
			valor_a_pagar_final= (600+120);
			
				escreva("O valor atual do seu plano de saúde é de R$ " + valor_a_pagar_final + " de acordo com a opção selecionada.");
			
			pare
			
		caso 03:
		
			valor_a_pagar_final= (600+150);
			
				escreva("O valor atual do seu plano de saúde é de R$ " + valor_a_pagar_final + " de acordo com a opção selecionada.");
			
			pare
			
		caso 04:
		
			valor_a_pagar_final= (600+190);
			
				escreva("O valor atual do seu plano de saúde é de R$ " + valor_a_pagar_final + " de acordo com a opção selecionada.");
			
			pare
			
		caso contrario:
			escreva("Opção invalida, por favor insira uma das opções apresentadas anteriomente!!");
		
		pare
		
		}
	
		
		
		
	}

}

//Criar um programa para calcular o valor da multa a ser paga de anuidade de uma associação. A
//anuidade deve ser paga no mês de janeiro. Por mês, é cobrado 5% de juros (com juros sobre juros).
//Por exemplo, uma associação de R$100 paga em janeiro, custa R$ 100; em fevereiro, custa
//R$105; em março, custa R$110,25; e, em dezembro, R$171,03.
//Obs: O usuário informa o valor da associação e o mês do pagamento, a partir disso o sistema
//retorna o valor a ser pago corrigido



exercicio_3{
	
	associacao_anuidade(){
		
		double valor_associacao, valor_a_ser_pago,periodo_mes, taxa_tempo;
		int mes;
		
		
		
		escreva("Insira o valor da associação :");
		leia(valor_associacao);
		
		escreva("Insira o mês de 01 a 12 que será ou foi realizado o pagamento da anuidade :");
		leia(mes);
		
		double mesConvert = mes; 																		// converção da variavel do tipo int para double
		
		periodo_mes= (mesConvert - 1);																	// o periodo a ser considerado sempre será 1 subtraido pelo mes informado pelo usuario
		
		taxa_tempo = (Math.Pow(1.05, periodo_mes));														// calculo para o periodo de tempo do juros
		
		valor_a_pagar_final =(valor_associacao * taxa_tempo);											// calculo para o valor final 
		
		
		escolha(mes){
		
		caso 01: 	
			
			escreva("O valor a ser pago no mês de Jeneiro é de R$ "+ valor_a_pagar_final);
		
			pare
		
		caso 02: 
			
			escreva("O valor a ser pago no mês de Fevereiro é de R$ "+ valor_a_pagar_final);
		
			pare
		
		caso 03: 
			
			escreva("O valor a ser pago no mês de Março é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 04: 
			
			escreva("O valor a ser pago no mês de Abril é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 05: 

			escreva("O valor a ser pago no mês de Maio é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 06: 
			
			escreva("O valor a ser pago no mês de Junho é de R$ "+ valor_a_pagar_final);
		
			pare
		
		caso 07: 
			
			escreva("O valor a ser pago no mês de Julho é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 08: 

			escreva("O valor a ser pago no mês de Agosto é de R$ "+ valor_a_pagar_final);
		
			pare
		
		caso 09: 

			escreva("O valor a ser pago no mês de Setembro é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 10:
			
			escreva("O valor a ser pago no mês de Outubro é de R$ "+ valor_a_pagar_final);
		
			pare
			
		caso 11: 

			escreva("O valor a ser pago no mês de Novembro é de R$ "+ valor_a_pagar_final);
		
			pare
					
		caso 12: 

			escreva("O valor a ser pago no mês de Dezembro é de R$ "+ valor_a_pagar_final);
		
			pare
		
				caso contrario:
			escreva("Opção invalida, por favor insira uma das opções dos meses apresentados anteriomente!! Sendo 01: janeiro, 02: fevereiro, 03: março, 04: abril, 05: maio, 06: junho, 07: julho, 08: agosto, 09: setembro, 10: outubro, 11: novembro e 12: dezembro ");
		
		pare
		
		}
		
	}
	
}





