using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_06
{
	class Aluno
	{
		public string Nome { get; set; }
		public int Idade { get; set; }
		public int Nota { get; set; }

		/* public static implicit operator string(Aluno aluno)		
			=> $"{aluno.Nome}, {aluno.Idade}, {aluno.Nota}";*/
	}
}
