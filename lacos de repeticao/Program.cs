int n1 = 0, max = 0, contador = 0, aux = 0;
// string nome = string.Empty;

Console.WriteLine("Digite um numero: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero incrementador: ");
max = int.Parse(Console.ReadLine());


Console.WriteLine("aqui é o for");
aux = n1;
for (contador = 0; contador <= max; contador++)
{
    Console.WriteLine(aux);
    aux ++;
}

contador = 0;
Console.WriteLine("aqui é o do");
aux = n1;
do
{
    Console.WriteLine(aux);
    aux++;
    contador++;
} while (contador <= max);

contador = 0;
Console.WriteLine("aqui é o while");

aux = n1;
while (contador <= max)
{
    Console.WriteLine(aux);
    aux++;
    contador++;
}

Console.ReadLine();