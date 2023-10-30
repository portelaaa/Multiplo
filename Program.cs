Console.WriteLine("Múltiplo");
Thread.Sleep(1000);
Console.Clear();
 
double numero1, numero2, resultado;
 
Console.WriteLine("Digite um número...");
numero1 = Convert.ToDouble(Console.ReadLine()!);
 
Console.WriteLine("Avaliar se é múltiplo de...");
numero2 = Convert.ToDouble(Console.ReadLine()!);
 
resultado = numero1 % numero2;
 
if(resultado == 0){
    Console.WriteLine($"{numero1} é múltiplo de {numero2}.");
}
else{
    Console.WriteLine($"{numero1} não é múltiplo de {numero2}.");
}
