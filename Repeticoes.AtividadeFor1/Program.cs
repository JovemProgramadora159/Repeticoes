// Peça o usuário um número inteiro e exiba para ela a tabuada de 1 a 10 utilizando o for
Console.Write("Digite um número inteiro: "); // Escreve uma linha no terminal
var numero = Convert.ToInt32(Console.ReadLine()); // Lê o que o usuário escreveu (ReadLine), Converte para inteiro (ToInt32) e atribui (=) o resultado final na variavel numero
Console.WriteLine("----- Tabuada -----"); // Escreve uma linha no terminal
for (var contador = 1; contador <= 10; contador++)
    // Cria um contador começando em 1, repete enquanto contado for menor ou igual a 10 (chegando em 11 ele para) e no final de toda repetição ele faz um incremento (aidiona mais 1 ao contador)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}"); // Exibe o numero que o usuario escolheu, o numero do contador e a multiplicação entre os dois
    Thread.Sleep(1000); // Espera 1 segundo (1000 milisegundos) antes de continuar
}
