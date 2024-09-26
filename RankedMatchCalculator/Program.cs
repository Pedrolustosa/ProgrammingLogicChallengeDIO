Console.WriteLine("Digite a quantidade de vitórias:");
int vitorias = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de derrotas:");
int derrotas = int.Parse(Console.ReadLine());
int saldoVitorias = CalculaSaldo(vitorias, derrotas);
string nivel = ClassificarNivel(vitorias);
Console.WriteLine($"O Herói tem um saldo de {saldoVitorias} e está no nível de {nivel}.");

int CalculaSaldo(int vitorias, int derrotas)
{
    return vitorias - derrotas;
}
string ClassificarNivel(int vitorias)
{
    if (vitorias < 10)
    {
        return "Ferro";
    }
    else if (vitorias >= 11 && vitorias <= 20)
    {
        return "Bronze";
    }
    else if (vitorias >= 21 && vitorias <= 50)
    {
        return "Prata";
    }
    else if (vitorias >= 51 && vitorias <= 80)
    {
        return "Ouro";
    }
    else if (vitorias >= 81 && vitorias <= 90)
    {
        return "Diamante";
    }
    else if (vitorias >= 91 && vitorias <= 100)
    {
        return "Lendário";
    }
    else
    {
        return "Imortal";
    }
}
