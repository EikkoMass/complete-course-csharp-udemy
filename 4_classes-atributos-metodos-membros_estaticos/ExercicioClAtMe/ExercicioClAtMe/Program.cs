using System;

namespace ExercicioClAtMe
{
	class Program
	{
		public static void Main(string[] args)
		{
			Aluno aluno = new Aluno();

			Console.Write("Nome do aluno: ");
			aluno.Nome = Console.ReadLine();

			Console.WriteLine("Digite as três notas do aluno: ");
			aluno.Notas[0] = int.Parse(Console.ReadLine());
			aluno.Notas[1] = int.Parse(Console.ReadLine());
			aluno.Notas[2] = int.Parse(Console.ReadLine());

			double NotaFinal = aluno.CalcularNota();

			Console.WriteLine($"Nota Final = {NotaFinal}");

			Boolean Aprovado = NotaFinal > 59;

			if(Aprovado)
			{
				Console.WriteLine("Aprovado");
			}
			else
			{
				Console.WriteLine("Reprovado");
				Console.WriteLine($"Faltaram {60 - NotaFinal} Pontos");
			}
		}
	}
}
