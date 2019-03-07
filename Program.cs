using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.CSharp.ConsoleApp.Examen
{
	public class Program
	{
		static void Main(string[] args)
		{
			Metro metros = new Metro() { Medida = 100 };
			Pulgada pulgadas = Conversor.ToPulgadas(metros);

			Console.WriteLine(pulgadas.Medida.ToString("N2"));     //Pinta 3.937,00

			Console.ReadKey();
		}
	}


	public interface ILongitud
	{
		decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Kilometro que implemente la interfaz ILongitud
	public class Kilometro : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Metro que implemente la interfaz ILongitud
	public class Metro : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Centimetro que implemente la interfaz ILongitud
	public class Centimetro : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Milimetro que implemente la interfaz ILongitud
	public class Milimetro : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Milla que implemente la interfaz ILongitud
	public class Milla : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase llamada Pulgada que implemente la interfaz ILongitud
	public class Pulgada : ILongitud
	{
		public decimal Medida { get; set; }
	}

	//TODO Crea una clase estática llamada Conversor
	public static class Conversor
	{
		public static Pulgada ToPulgadas<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Pulgada nuevo = new Pulgada();
			decimal aMetro = il.Medida * (decimal)39.37;
			switch (tipo)
			{
				case "Metro":
					nuevo.Medida = aMetro;
					break;
				case "Centimetro":
					nuevo.Medida = il.Medida *  100;
					break;
				case "Milimetro":
					nuevo.Medida = il.Medida * 1000;
					break;
				case "Milla":
					nuevo.Medida = il.Medida / (decimal)1609.344;
					break;
				case "Kilometro":
					nuevo.Medida = il.Medida / 1000;
					break;
			}
			return nuevo;
		}

		public static Milla ToMillas<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Milla nuevo = new Milla();
			decimal aMetro = il.Medida / (decimal)1609.344;
			switch (tipo)
			{
				case "Metro":
					nuevo.Medida = aMetro;
					break;
				case "Centimetro":
					nuevo.Medida = il.Medida *  100;
					break;
				case "Milimetro":
					nuevo.Medida = il.Medida * 1000;
					break;
				case "Pulgada":
					nuevo.Medida = il.Medida * (decimal)39.37;
					break;
				case "Kilometro":
					nuevo.Medida = il.Medida / 1000;
					break;
			}
			return nuevo;
		}

		public static Milimetro ToMilimetros<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Milimetro nuevo = new Milimetro();
			decimal aMetro = il.Medida * 1000;
			switch (tipo)
			{
				case "Metro":
					nuevo.Medida = aMetro;
					break;
				case "Centimetro":
					nuevo.Medida = il.Medida *  100;
					break;
				case "Milla":
					nuevo.Medida = il.Medida / (decimal)1609.344;
					break;
				case "Pulgada":
					nuevo.Medida = il.Medida * (decimal)39.37;
					break;
				case "Kilometro":
					nuevo.Medida = il.Medida / 1000;
					break;
			}
			return nuevo;
		}

		public static Centimetro ToCentimetros<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Centimetro nuevo = new Centimetro();
			decimal aMetro = il.Medida * 100;
			switch (tipo)
			{
				case "Metro":
					nuevo.Medida = aMetro;
					break;
				case "Milimetro":
					nuevo.Medida = il.Medida * 1000;
					break;
				case "Milla":
					nuevo.Medida = il.Medida / (decimal)1609.344;
					break;
				case "Pulgada":
					nuevo.Medida = il.Medida * (decimal)39.37;
					break;
				case "Kilometro":
					nuevo.Medida = il.Medida / 1000;
					break;
			}
			return nuevo;
		}

		public static Metro ToMetros<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Metro nuevo = new Metro();
			switch (tipo)
			{
				case "Centimetro":
					nuevo.Medida = il.Medida * 100;
					break;
				case "Milimetro":
					nuevo.Medida = il.Medida * 1000;
					break;
				case "Milla":
					nuevo.Medida = il.Medida / (decimal)1609.344;
					break;
				case "Pulgada":
					nuevo.Medida = il.Medida * (decimal)39.37;
					break;
				case "Kilometro":
					nuevo.Medida = il.Medida / 1000;
					break;
			}
			return nuevo;
		}

		public static Kilometro ToKilometros<T>(T obj)
		{
			ILongitud il = obj as ILongitud;
			string tipo = il.GetType().Name.ToString();
			Kilometro nuevo = new Kilometro();
			decimal aMetro = il.Medida / 1000;
			switch (tipo)
			{
				case "Centimetro":
					nuevo.Medida = il.Medida * 100;
					break;
				case "Milimetro":
					nuevo.Medida = il.Medida * 1000;
					break;
				case "Milla":
					nuevo.Medida = il.Medida / (decimal)1609.344;
					break;
				case "Pulgada":
					nuevo.Medida = il.Medida * (decimal)39.37;
					break;
				case "Metro":
					nuevo.Medida = aMetro;
					break;
			}
			return nuevo;
		}
	}
	//TODO Crea un método ToKilometros que devuelve un objeto Kilometro y recibe como parámetro un objeto del tipo genérico
	//TODO Crea un método ToMetros que devuelve un objeto Metro y recibe como parámetro un objeto del tipo genérico
	//TODO Crea un método ToCentimetros que devuelve un objeto Centimetro y recibe como parámetro un objeto del tipo genérico
	//TODO Crea un método ToMilimetros que devuelve un objeto Milimetro y recibe como parámetro un objeto del tipo genérico
	//TODO Crea un método ToMillas que devuelve un objeto Milla y recibe como parámetro un objeto del tipo genérico
	//TODO Crea un método ToPulgadas que devuelve un objeto Pulgada y recibe como parámetro un objeto del tipo genérico
	//
	//TODO Cada método debe transformar el valor de la propiedad Medida y retonar el nuevo valor.
	//
	//DATOS     1 kilometro = 1000 metros       *   1 metro = 1 metro           *   1 centimetro = 1 / 100 metros
	//          1 milimetro = 1 / 1000 metros   *   1 milla = 1609.344 metros   *   1 pulgada = 1 / 39.37 metros
	//
	//EJEMPLO     public static Kilometro ToKilometros<T>(T obj)
}
