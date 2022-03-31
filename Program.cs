using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.Diagnostics;

namespace Desafio_06
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Aluno> listaAluno = new List<Aluno>();

			Aluno aluno = new Aluno();
			aluno.Nome = "Joaquina";
			aluno.Idade = 40;
			aluno.Nota = 8;

			Aluno aluno2 = new Aluno();
			aluno2.Nome = "Jeremias";
			aluno2.Idade = 27;
			aluno2.Nota = 5;

			Aluno aluno3 = new Aluno();
			aluno3.Nome = "Joana";
			aluno3.Idade = 30;
			aluno3.Nota = 10;

			listaAluno.Add(aluno);

			foreach (Aluno aluno1 in listaAluno)
			{
				Console.WriteLine("A soma da nota dos alunos é: " + (aluno.Nota + aluno2.Nota + aluno3.Nota));

			}

			using (var workbook = new XLWorkbook()) 
			{
				var worksheet = workbook.Worksheets.Add("Planilha1");
				worksheet.Cell("A1").Value = ("Nome");
				worksheet.Cell("A2").Value = aluno.Nome;
				worksheet.Cell("A3").Value = aluno2.Nome;
				worksheet.Cell("A4").Value = aluno3.Nome;

				worksheet.Cell("B1").Value = ("Idade");
				worksheet.Cell("B2").Value = aluno.Idade;
				worksheet.Cell("B3").Value = aluno2.Idade;
				worksheet.Cell("B4").Value = aluno3.Idade;

				worksheet.Cell("C1").Value = ("Nota");
				worksheet.Cell("C2").Value = aluno.Nota;
				worksheet.Cell("C3").Value = aluno2.Nota;
				worksheet.Cell("C4").Value = aluno3.Nota;

				workbook.SaveAs(@"C:\Usuários\laris\OneDrive\Desafio_05.xlsx");
			}

			Process.Start(new ProcessStartInfo(@"C:\Usuários\laris\OneDrive\Desafio_05.xlsx") { UseShellExecute = true });



			Console.ReadLine();
		}
		
	}
	
}
