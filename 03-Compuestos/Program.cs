
static void func1(int arg1, int arg2)
{
    string resultado = (arg1 + arg2).ToString();
    Console.WriteLine(resultado);
};

static void func2(int arg1, int arg2)
{
    string resultado = (arg1 * arg2).ToString();
    Console.WriteLine(resultado);
}

MiDelegado f1 = func1;
MiDelegado f2 = func2;

MiDelegado f1f2 = f1 + f2;
int arg1 = 40;
int arg2 = 30;

Console.WriteLine("Se esta ejecutando el primer delegate");
f1(arg1, arg2);

Console.WriteLine("Se esta ejecutando el segundo delegate");
f2(arg1, arg2);

Console.WriteLine("Se estan ejecutando el primer y el segundo delegate al mismo tiempo");
f1f2(arg1, arg2);

f1f2 -= f2;

Console.WriteLine("Ejecutando la concatenacion pero sin el f2");
f1f2(arg1, arg2);

public delegate void MiDelegado(int arg1, int arg2);