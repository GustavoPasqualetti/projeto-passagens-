Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($@"
------------------------------
|   Ola! seja bem vindo a    |
|  nossa agência de turismo  |
------------------------------");
Console.ResetColor();

Console.WriteLine($"Digite a senha para entrar no Menu:");
string senhalogin = Console.ReadLine();

while (senhalogin != "123456")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Digite uma senha valida");
    Console.ResetColor();
    senhalogin = Console.ReadLine();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Acesso Liberado!");
Console.ResetColor();
Console.WriteLine(@$"
1- Cadastrar passagem
2- Listar Passagens
0- Sair");
string cadastrar = Console.ReadLine();

string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

if (cadastrar == "1")
{
    for (var i = 0; i < 3; i++)
    {
        Console.WriteLine($"Cadastre o {i + 1}º Passageiro");
        Console.WriteLine($"Nome do {i + 1}º passageiro");
        nome[i] = Console.ReadLine();
        Console.WriteLine($"Origem do {i + 1}º passageiro");
        origem[i] = Console.ReadLine();
        Console.WriteLine($"Destino do {i + 1}º passageiro ");
        destino[i] = Console.ReadLine();
        Console.WriteLine($"Data do voo");
        data[i] = Console.ReadLine();
        Console.WriteLine($"");
    }
    Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Passageiros cadastrados");
Console.ResetColor();
}


Console.WriteLine(@$"
1- Cadastrar passagem
2- Listar Passagens
0- Sair");
string cadastrar2 = Console.ReadLine();

if (cadastrar2 == "2" || cadastrar == "2")
{
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine($"Cadastro do {i + 1}º passageiro");

        Console.WriteLine($"Nome do {i + 1}º passageiro é: {nome[i]} ");
        Console.WriteLine($"O local de origem do {i + 1}º passageiro é: {origem[i]}");
        Console.WriteLine($"O local de destino do {i + 1}º passageiro é: {destino[i]}");
        Console.WriteLine($"A data do voo do {i + 1}º é: {data[i]}");
        Console.WriteLine($"");

    }

}
if (cadastrar == "0" || cadastrar2 == "0")
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($@"
-------------------------
|   Obrigado por usar   |
|    o nosso sistema    |
-------------------------");
    Console.ResetColor();
}





