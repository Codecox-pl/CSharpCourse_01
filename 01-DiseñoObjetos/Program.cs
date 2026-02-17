
using _01_DiseñoObjetos;

var autores = new Estudiante[10];

autores[0] = new Estudiante("Patrick", "Luis");
autores[1] = new Estudiante("Claudia", "Ruiz");
autores[2] = new Estudiante("Camilo", "Flores");
autores[3] = new Estudiante("Valentina", "Quispe");
autores[4] = new Estudiante("Zoro", "Montezco");
autores[5] = new Estudiante("Sanji", "Aguero");
autores[6] = new Estudiante("Luffy", "Ramirez");

Array.Sort(autores);

//foreach (var estudiante in autores)
//{
//    Console.WriteLine(estudiante);
//}

for (int i = 0; i < autores.Length; i++)
{

    // Solo imprime si NO es nulo
    if (autores[i] != null)
    {
        Console.WriteLine(autores[i]);
    }
    
}