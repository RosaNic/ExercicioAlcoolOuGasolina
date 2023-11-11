Console.Clear();

string opcao;

Console.WriteLine
    ("--- Àlcool ou Gasolina ---\n");

Console.Write
    ("Informe o preço do Etanol (R$)....: ");
Decimal Alcool = Convert.ToDecimal(Console.ReadLine());

Console.Write
    ("\nInforme o preço da Gasolina (R$)..: ");
Decimal Gasolina = Convert.ToDecimal(Console.ReadLine());

if (UseGasolina(Alcool, Gasolina))
{
    opcao = "Gasolina";
}
else
{
    opcao = "Àlcool";
}

double razao = opcao1(Alcool, Gasolina) * 100;

double opcao1(decimal precoA, decimal precoG)
{
    return Convert.ToDouble(precoA / precoG);
}

bool UseGasolina(decimal precoA, decimal precoG)
{
    double MinOpcao1 = 0.73;
    return opcao1(precoA, precoG) >= MinOpcao1;
}

Console.WriteLine
    ($"\nO preço do àlcool corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine
    ($"Recomendação: Abasteça com {opcao}.");