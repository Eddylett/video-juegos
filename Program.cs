using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Console.Write("Hola mundo");//soy un comentario
Console.Write("Hola mundo 2");
/*
soy un bloque
de comentarios
*/
Console.WriteLine();
Console.WriteLine("Ingrese nombre: ");
string? nombre=Console.ReadLine();
Console.WriteLine("Su nombre es: "+nombre);
int edad=32, peso=100;
float estatura=1.67f;
double promedio=1.67;
bool estaVivo=true;
char letra='c';
Console.WriteLine("Ingrese edad: ");
edad=int.Parse(Console.ReadLine());
Console.WriteLine("El próximo año tendrá: "+(edad+1));
int a=23;
double b=a;
double aa=2.3;
int bb=(int)aa;
string h=aa.ToString("f3");//convertir en string
Console.WriteLine("h="+h);
bool estarVivo=int.TryParse("30",out int zz);
Console.WriteLine(estarVivo);
Console.WriteLine("zz="+(zz+1));
//+, -, /, *, %
edad=edad+1;
edad+=1;
edad++;
//>, <, >=, <=, !=, ==, &&, ||, !

if (edad>=18 && peso < 100)
{
    Console.WriteLine("Puede jugar");
}
else if(estatura<2)
{
    Console.WriteLine("Pedir autorización");
}
else
{
    System.Console.WriteLine("No cumple");
}

int op=2;
switch (op)
{
    case 1:
        System.Console.WriteLine("Selección opción 1.");
        System.Console.WriteLine("Felicidades");
        break;
    case 2:
        System.Console.WriteLine("Selección opción 2.");
        System.Console.WriteLine("Felicidades");
        break;
    default:
        System.Console.WriteLine("No selecciona una opción válida.");
        System.Console.WriteLine("Adios");
        break;
}

op=2;
float velocidad = op switch{
    1 => 1.0f,
    2 => 2.5f,
    _ => 1.5f
 };

for (int i = 1; i <= 10; i+=2)
{
    Console.WriteLine(i);
}



int Suma (int a, int b)
{
    Console.Write($"{a}+{b}=");
    return a+b;
}
Console.Write($"{Suma (3,4)}");
Console.WriteLine("");

Console.WriteLine(Ataque(1000,200));


string Ataque(int daño, int vida )
{
    if (vida-daño > 0)
    {
        return $"Luego del ataque su vida es {vida-daño}";
    }
    else
    {
        
        return$"¡You Died!";
    }
    

}


void Saludo(string nombre)
{
    Console.WriteLine($"¡¡Bienvenido {nombre}!!");
}

Saludo("Eddy Rosales");


