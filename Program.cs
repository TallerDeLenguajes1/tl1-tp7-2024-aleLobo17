// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;//es uimportante para poder usar las cosas de calculadora.cs

Console.WriteLine("Hello, World!");

calculadora micalculadora = new calculadora();

micalculadora.Sumar(10);
Console.WriteLine(micalculadora.RESULTADO);
micalculadora.Multiplicar(3);
Console.WriteLine(micalculadora.RESULTADO);
micalculadora.Restar(2);
Console.WriteLine(micalculadora.RESULTADO);
micalculadora.Dividir(2);
Console.WriteLine(micalculadora.RESULTADO);

micalculadora.Limpiar();
Console.WriteLine(micalculadora.RESULTADO);




