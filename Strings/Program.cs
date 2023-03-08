string nome;

string LerString()
{
    Console.WriteLine("Digite uma frase: \n");
    return Console.ReadLine();
}

int VerificaTamanho(string texto)
{
    return texto.Length;

}

void AlternaCaptalize(string texto)
{
    texto = texto.ToLower();
    char[] aux = texto.ToCharArray();
    char[] textoNovo = new char[texto.Length];
    for (int i = 0; i < aux.Length; i++)
    {
        if (i % 2 == 0)
        {
            textoNovo[i] = char.ToUpper(aux[i]);
        }
        else
        {
            textoNovo[i] = (aux[i]);
        }
    }
    Console.WriteLine(textoNovo);
}

int ContaVogal(string texto)
{
    int sum = 0;
    char[] aux = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    for (int i = 0; i < texto.Length; i++)
    {
        for (int j = 0; j < aux.Length; j++)
        {
            if (texto[i] == aux[j])
            {
                sum++;
            }
        }
    }
    return sum;
}

int ContaConsoante(string texto)
{
    int sum = 0;
    char[] aux = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    for (int i = 0; i < texto.Length; i++)
    {
        if ((((int)texto[i] > 64) && ((int)texto[i] < 91)) || ((((int)texto[i] > 96) && ((int)texto[i] < 123))))
        {
            sum++;
            for (int j = 0; j < aux.Length; j++)
            {
                if (texto[i] == aux[j])
                {
                    sum--;
                }
                   
            }
        }
    }
        return sum;
}

string EspelhaString(string texto)
{
    char[] charTexto = texto.ToCharArray();
    string aux = "\0";
    for (int i = texto.Length-1; i >= 0; i--)
    {
        aux += charTexto[i];
    }
    return aux;
}

nome = LerString();
Console.WriteLine(VerificaTamanho(nome));
AlternaCaptalize(nome);
Console.WriteLine(ContaVogal(nome));
Console.WriteLine(ContaConsoante(nome));
Console.WriteLine(EspelhaString(nome));