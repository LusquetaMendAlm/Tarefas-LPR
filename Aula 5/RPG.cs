using System;

class Program {
  public static void Main (string[] args) {
   string classe;
    Console.WriteLine ("Qual classe você deseja ser? \n * guerreira \n * mago \n * arqueira");
    classe = Console.ReadLine();
    switch (classe){
    case "guerreira":
      Console.WriteLine("Parabéns, você é uma guerreira e possui as habiliades: \n -Ataque Pesado \n -Defesa total");
      break;
    case "mago":
      Console.WriteLine("Parabéns, você é um mago e possui as habiliades: \n -Bola de fogo \n -Escudo de gelo");
      break;
    case "arqueira":
      Console.WriteLine("Parabéns, você é uma arqueira e possui as habiliades: \n -Flecha precisa \n -Disparo triplo");
      break;
    }
  }
}