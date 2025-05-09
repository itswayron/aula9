// See https://aka.ms/new-console-template for more information
using aula09;

Console.WriteLine("Hello, World!");
var retangulo = new Retangulo(20, 20);
var data = new DataStruct("10/10/2005");
Console.WriteLine($"Area do retangulo: {retangulo.getArea()}. Perimetro do retangulo: {retangulo.getPerimetro()}.");
var cor = new Cor(255, 165, 0);
Console.WriteLine($"Cor em HEX é: {cor.toHex()}");  
var produto = new Produto("Computador", 2550.5, 10);
Console.WriteLine($"O estoque total de {produto.Nome} é de R${produto.getValorEstoque():F2}");