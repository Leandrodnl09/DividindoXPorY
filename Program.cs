// Exercício do site URI "Dividindo X por Y"
// Nesse programa o usuário ira digita um numero inteiro pra identificar a quantidade de "x" e "y" que seram digitados em sequnecia na mesma linha.
// Deois de recolher os dados irá aparecer na tela a divisão entre eles e se não for possível dividir irá aparecer uma mensagem "divisão impossivel"


int N = int.Parse(Console.ReadLine());
double Result;
for (int i = 1; i <= N; i++)
{
    string [] Num = Console.ReadLine().Split(' ');
    int X = int.Parse(Num[0]);
    int Y = int.Parse(Num[1]);

    if (Y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        Result = (double) X / Y;
        Console.WriteLine(Result.ToString("F1"));
    }
}
