using System;

class Program {
  public static void Main (string[] args) {
// Faça um algoritmo para ler as 3 notas obtidas por um aluno nas 3 verificações e a média dos exercícios que fazem parte da avaliação. Calcular a média de aproveitamento, usando a fórmula abaixo e escrever o conceito do aluno de acordo com a tabela de conceitos mais abaixo:  

//N1 + N2 * 2 + N3 * 3 + Média_dos_Exercícios 
  //Média_de_Aproveitamento =	 7 

//A atribuição de conceitos obedece a tabela abaixo: 
//Média de Aproveitamento 
//A > = 9,0 
//B > = 7,5 e < 9,0 
//C > = 6,0 e < 7,5 
//D < 6,0 

Double nFinal,nota1,nota2,nota3,exercicios;
String entrada;

Console.WriteLine ("Digite nota 1: ");
entrada = Console.ReadLine ();
nota1 = Double.Parse(entrada);
    
Console.WriteLine ("Digite a nota 2:"); 
entrada = Console.ReadLine ();
nota2 = Double.Parse(entrada);

Console.WriteLine ("Digite  a nota 3:");
entrada = Console.ReadLine ();
nota3 = Double.Parse(entrada);
 
Console.WriteLine ("Digite a Media dos Exercicios");
entrada = Console.ReadLine ();
exercicios = Double.Parse(entrada);

nFinal = (nota1+2*nota2+3*nota3+exercicios) / 7;

if (nFinal >=9)

{Console.WriteLine ("Conceito A");
}
if (nFinal >=7.5 && nFinal <9)

{Console.WriteLine ("Conceito B");
}

if (nFinal >=6 && nFinal <7.5)

{Console.WriteLine ("Conceito C");
}
if (nFinal <6)
{
Console.WriteLine ("Conceito D");
}

  }
}