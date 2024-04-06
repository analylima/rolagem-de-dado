using System.Security.Cryptography;

int faces, sorteado;

Console.Write("--- Rolagem de dado ---\n");

Console.Write("Quantas faces? ");
faces = Convert.ToInt32(Console.ReadLine());

sorteado = RandomNumberGenerator.GetInt32(1, faces + 1);

Console.WriteLine($"\nRolagem: {sorteado}");
