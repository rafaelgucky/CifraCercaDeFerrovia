/*

 Mostrar menu com opções: cifrar ou decifrar - Feito
 Ler mensagem - Feito
 Desenvolver a lógica - Feito
 Mostrar mensagem

*/

using System.Text;

int op = 0;
string msg = string.Empty;
string part1 = string.Empty;
string part2 = string.Empty;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("1 - Cifrar");
Console.WriteLine("2 - Decifrar");

while (op <= 0 || op > 2)
{
    Console.Write("Opção: ");
    _ = int.TryParse(Console.ReadLine(), out op);
}

while (string.IsNullOrEmpty(msg))
{
    Console.Write("Escreva a mensagem: ");
    msg = Console.ReadLine()!;
}

if (op == 1)
{
    for (int i = 0; i < msg.Length; i++)
    {
        if (i % 2 == 0)
        {
            part1 += msg[i];
        }
        else
        {
            part2 += msg[i];
        }
    }
    Console.WriteLine(part1 + part2);
}
else
{
    int count = 0;
    while (part1.Length < msg.Length)
    {
        if (part1.Length % 2 == 0)
        {
            part1 += msg[count];
        }
        else
        {
            part1 += msg[count + (int)Math.Ceiling(msg.Length / 2.0)];
            count++;
        }
    }
    Console.WriteLine(part1);
}