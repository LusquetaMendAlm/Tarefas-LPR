using System;

class Program {
  public static void Main (string[] args) {
    int divisao;
    Console.WriteLine ("Digite dois números inteiros com um espaço de distância para saber se eles são múltiplos:");
    string [] nums = Console.ReadLine(). Split(' ');
    int A = int.Parse(nums[0]);
    int B = int.Parse(nums[1]);
    if ( A == 0 || B == 0){
    Console.WriteLine("Os números são múltiplos");
    }
    else if (A > B){
      divisao = A % B;
        switch (divisao){
        case 0 : 
          Console.WriteLine("Os números são múltiplos");
          break;
        default :
          Console.WriteLine("Os números não são múltiplos");
          break;
        }
    }
      else if ( B > A){
        divisao = B % A;
        switch (divisao){
        case 0 : 
          Console.WriteLine("Os números são múltiplos");
          break;
        default :
          Console.WriteLine("Os números não são múltiplos");
          break;
        }
      }
      else {
      Console.WriteLine("Os números são múltiplos");
      }


  }
}