string [] nomes = new string [10];

bool NomeEncontrado =  false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"informe o {i + 1}º nome: ") ;
    nomes[i] = (Console.ReadLine()!);
    
    
}

Console.WriteLine($"Informe o nome a ser buscado: ");
string nomeBuscado = (Console.ReadLine()!);

foreach (string nome in nomes)
{
     if (nome == nomeBuscado)
     {

NomeEncontrado = true; 
break;

     }
}

 Console.WriteLine(NomeEncontrado ? "Nome encontrado" : "Nome não encontrado");
 