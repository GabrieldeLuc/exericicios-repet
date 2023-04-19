Console.WriteLine($"Bem vindo ao Sistema, informe o nome do produto: ");
string nome = (Console.ReadLine()!);

Console.WriteLine($"Agora, informe a quantidade que você adquiriu: ");
int quantidade = int.Parse (Console.ReadLine()!);

Console.WriteLine($"informe o preço de cada unidade do produto: ");
float preco = float.Parse (Console.ReadLine()!);


float total = (quantidade * preco);

if (quantidade <= 5) {

float totalpago = (total * 0.98f);
Console.WriteLine($"o preço final é {totalpago}");

}

else if (quantidade > 5 && quantidade <= 10) {

float totalpago = (total * 0.97f);
    Console.WriteLine($"o preço final é {totalpago}");
    
}

else {

    float totalpago = (total * 0.95f);
    Console.WriteLine($"o preço final é {totalpago}");
    
}


