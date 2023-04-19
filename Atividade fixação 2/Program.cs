class Program {
    static void Main(string[] args) {
    
        const double precoGasolina = 5.30;
        const double precoAlcool = 4.90;

        Console.Write("Digite o número de litros vendidos: ");
        int litros = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o tipo de combustível (A-álcool, G-gasolina): ");
        char tipoCombustivel = char.Parse(Console.ReadLine()!);


        double precoPorLitro;
        if (tipoCombustivel == 'A') {
            if (litros <= 20) {
                precoPorLitro = precoAlcool * 0.97; 
            } else {
                precoPorLitro = precoAlcool * 0.95; 
            }
        } else if (tipoCombustivel == 'G') {
            if (litros <= 20) {
                precoPorLitro = precoGasolina * 0.96;
            } else {
                precoPorLitro = precoGasolina * 0.94; 
            }
        } else {
            Console.WriteLine("Tipo de combustível inválido.");
            return;
        }

        double valorTotal = litros * precoPorLitro;

        Console.WriteLine($"Valor total a pagar: R$ {valorTotal:F2}");
    }
}








