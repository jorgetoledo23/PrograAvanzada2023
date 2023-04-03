using AppConsola;

//Imprimir por Pantalla (Print)
Console.WriteLine("Bienvenido Semestre Otoño 2023");

//Lee la entrada desde la Consola
Console.ReadLine();

//C# lenguaje full Tipado
int entero = 20;
string cadena = "Hola";
bool flag = true;
bool flag2 = false;
double num2 = 1.1;

//Objeto de tipo Persona
Persona persona = new Persona();
persona.Nombre = "Jhon";
persona.Apellido = "Snow";


Console.WriteLine("Ingresan el Primer Numero: ");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresan el Segundo Numero: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

int resultado = numOne + numTwo;
Console.WriteLine($"El resultado es { resultado }");




