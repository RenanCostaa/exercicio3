using System;

class MainClass {
  //3. Faça um Programa que peça dois números e imprima a soma.
  public static void soma(float a, float b){
    float result = a + b;
    Console.Write("O resultado da sua soma foi: ");
    Console.WriteLine(result);
  }

  public static void Main (string[] args) {
    float val1, val2;
    Console.Write("Primeiro valor p/ soma: ");
    val1 = float.Parse(Console.ReadLine());
    Console.Write("Segundo valor p/ soma: ");
    val2 = float.Parse(Console.ReadLine());
    soma(val1,val2);
  }
}