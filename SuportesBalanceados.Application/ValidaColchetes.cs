namespace SuportesBalanceados.Application;

public static class ValidaColchetes
{
    public static bool Validar(string s)
    {
        Stack<char> pilha = new();
        Dictionary<char, char> correspondentes = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach(char c in s)
        {
            if(correspondentes.ContainsKey(c))
            {
                pilha.Push(c);
            }
            else if(pilha.Count == 0 || correspondentes[pilha.Pop()] != c)
            {
                return false;
            }
        }

        return pilha.Count == 0;
    }
}
