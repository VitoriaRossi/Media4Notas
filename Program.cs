Console.Write("Digite sua 1ª Nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua 2ª Nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua 3ª Nota: ");
double n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua 4ª Nota: ");
double n4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

double media;
string resultado;

if (n1 >= 0 && n1 < 11
  && n2 >= 0 && n2 < 11
  && n3 >= 0 && n3 < 11
  && n4 >= 0 && n4 < 11)
  {
    media = (n1 + n2 + n3 + n4) / 4;

    if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media > 6)
    {
        resultado = "Aprovado";
    }
    else
    {
        resultado = "Em recuperação";
    }

    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}

