public class Fila
{
    public Pessoa Head;
    public Pessoa Tail;
    public int Contador;

    public Fila()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null)
        {
            return true;
        }
        return false;
    }

    public void InseriElemento(Pessoa aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Proximo = aux;
            Tail = aux;
        }
        Contador++;
    }

    public void RemoverElemento()
    {
        if (!FilaVazia())
        {
            Head = Head.Proximo;
            Contador--;
        }
        else
        {
            Tail = null;
        }
    }

    public int GetFila()
    {
        return Contador;
    }
}