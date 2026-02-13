
MiDelegado f = delegate (int i, string s)
{
    return i + 100;
};

int resultado = f(200, "Hola");


public delegate int MiDelegado(int i, string s);