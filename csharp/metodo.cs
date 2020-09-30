using System;
using System.IO;


namespace programajava
{

	
	public class metodo
	{

	internal string texto = "";
		internal string[] ordenado = new string[] {"Yo", "soy", "groot..."};
		internal string[] desordenado;

		public virtual void leer()
		{

		   //Realiza lectua del archivo txt y guarda en un arreglo
			try
			{
				StreamReader bf = new StreamReader("C:\\Users\\Daniel\\Desktop\\programacion logica y funcional\\csharp\\frase.txt");
				string temp = "";
				string bfRead;
				while (!string.ReferenceEquals((bfRead = bf.ReadLine()), null))
				{
					temp = temp + bfRead;
					texto = temp;
					desordenado = texto.Split(" ", true);

				}
				Console.WriteLine("--------------Frase desordenada----------------");
				for (int i = 0; i < desordenado.Length; i++)
				{
					Console.WriteLine(desordenado[i]);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("error" + e);
			}

			//ordena arreglo-algorito burbuja 
			for (int i = 0; i < ordenado.Length - 1; i++)
			{
			for (int j = 0; j < ordenado.Length - 1; j++)
			{
			if ((ordenado[j].Equals(desordenado[j], StringComparison.OrdinalIgnoreCase)) != true)
			{
						string aux = desordenado[j];
						desordenado[j] = desordenado[j + 1];
						desordenado[j + 1] = aux;

			}
			}

			}


			//imprime frase ordenada 
			Console.WriteLine("\n--------------frase ordenada-------------------");
			for (int i = 0; i < desordenado.Length; i++)
			{
				Console.Write(desordenado[i] + " ");
			}
		}
	}


}