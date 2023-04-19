int [] numeros = new int [10];



for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Bem vindo ao Sistema, informe o {i + 1}º número: ");
     numeros [i] = int.Parse(Console.ReadLine()!);


}

int maior = numeros[0];
int menor =  numeros[0];

for (var i = 0; i < numeros.Length; i++)
{
if (i == 0) {   

menor = numeros [0];
maior = numeros [0];

 }

  if (numeros[i] < menor)
   {
        menor = numeros[i];
    }
    if (numeros[i] > maior)     {
       maior = numeros[i];
    }
 }

Console.WriteLine($"O menor número é {menor}");
 Console.WriteLine($"O maior número é {maior}");


  

