// Peça o usuário um número inteiro e exiba para ela a tabuada de 1 a 10 utilizando o for
Console.Write("Digite um número inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----- Tabuada -----");
for (var contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    Thread.Sleep(1000);
}