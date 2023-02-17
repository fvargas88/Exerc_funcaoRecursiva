using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um número para iniciar o contador: ");
    contar(int.Parse(Console.ReadLine()));
    
  }
  public static void contar(int n){
    if (n ==0)
    return;

    Console.WriteLine(n);
    contar(n-1);
  }
}