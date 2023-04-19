Console.WriteLine($"Bem vindo ao Sistema, informe o ano Atual: ");
int AnoAtual = int.Parse (Console.ReadLine()!);

Console.WriteLine($"Agora, informe o ano ao qual você nasceu: ");
int AnodeNascimento = int.Parse (Console.ReadLine()!);



if (AnoAtual - AnodeNascimento < 16) 
Console.WriteLine($"Você não tem idade suficiente para votar");

else 
Console.WriteLine($"Você já pode votar !");


