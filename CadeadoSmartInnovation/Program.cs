int[] combinacao = { 0, 1, 0, 0, 1, 1, 0, 1, 0, 1 }; // combinação para abrir o cadeado
ImprimirTodasCombinacoes(combinacao);
Console.ReadKey();

void ImprimirTodasCombinacoes(int[] combinacao)
{
    Console.WriteLine("Todas as combinações possíveis:");
    int numCombinacoes = (int)Math.Pow(2, combinacao.Length);
    for (int i = 0; i < numCombinacoes; i++)
    {
        int[] seq = DecimalParaBinario(i, combinacao.Length);
        Console.Write("Combinação {0}: ", i);
        for (int j = 0; j < seq.Length; j++)
        {
            Console.Write(seq[j] == 0 ? "A " : "B ");
        }
        Console.WriteLine();
    }
    int posicao = EncontrarPosicao(combinacao);
    Console.WriteLine("O cadeado será aberto na posição {0}", posicao);
}

int EncontrarPosicao(int[] combinacao)
{
    int numCombinacoes = (int)Math.Pow(2, combinacao.Length);
    for (int i = 0; i < numCombinacoes; i++)
    {
        int[] seq = DecimalParaBinario(i, combinacao.Length);
        bool encontrou = true;
        for (int j = 0; j < seq.Length; j++)
        {
            if (seq[j] != combinacao[j])
            {
                encontrou = false;
                break;
            }
        }
        if (encontrou)
        {
            return i;
        }
    }
    return -1;
}

int[] DecimalParaBinario(int n, int tamanho)
{
    int[] binario = new int[tamanho];
    for (int i = tamanho - 1; i >= 0; i--)
    {
        binario[i] = n % 2;
        n /= 2;
    }
    return binario;
}
