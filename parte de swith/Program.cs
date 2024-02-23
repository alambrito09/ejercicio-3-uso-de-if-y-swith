Console.WriteLine("parte 1# usando switch");
    string numeroenLetras;
int numeroenDigito;
int numeroDia;
string tipoServicio;
double importe;
string idioma;
int calificacion;
Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
numeroenLetras = Console.ReadLine().ToLower();
switch (numeroenLetras)
{
    case "uno":
        numeroenDigito = 1;
        break;
    case "dos":
        numeroenDigito = 2;
        break;
    case "tres":
        numeroenDigito = 3;
        break;
    case "cuatro":
        numeroenDigito = 4;
        break;
    case "cinco":
        numeroenDigito = 5;
        break;
    default:
       
        Console.WriteLine("El número ingresado no es válido.");
        return;
}

Console.WriteLine("El número en dígito es: {0}", numeroenDigito);
Console.WriteLine("parte 2# ");
 


Console.WriteLine("Ingrese un número del 1 al 7:");
numeroDia = int.Parse(Console.ReadLine());

switch (numeroDia)
{
    case 1:
        Console.WriteLine("El día de la semana es: Lunes");
        break;
    case 2:
        Console.WriteLine("El día de la semana es: Martes");
        break;
    case 3:
        Console.WriteLine("El día de la semana es: Miércoles");
        break;
    case 4:
        Console.WriteLine("El día de la semana es: Jueves");
        break;
    case 5:
        Console.WriteLine("El día de la semana es: Viernes");
        break;
    case 6:
        Console.WriteLine("El día de la semana es: Sábado");
        break;
    case 7:
        Console.WriteLine("El día de la semana es: Domingo");
        break;
    default:
        
        Console.WriteLine("El número ingresado no es válido.");
        break;
}
Console.WriteLine("parte 3#");
Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revision mecanica):");
tipoServicio = Console.ReadLine().ToLower();
tipoServicio = tipoServicio.ToLower();
switch (tipoServicio)
{
    case "lavado de auto":
        importe = 20.0;
        break;
    case "cambio de aceite":
        importe = 50.0;
        break;
    case "revision mecanica":
        importe = 100.0;
        break;
    default:
     
        Console.WriteLine("El tipo de servicio ingresado no es válido.");
        return;
}


Console.WriteLine("El importe a pagar es: ${0}", importe);
Console.WriteLine("parte 4#");
Console.WriteLine("Ingrese el idioma de su preferencia (español, ingles, frances):");
idioma = Console.ReadLine().ToLower();


idioma = idioma.ToLower();


switch (idioma)
{
    case "español":
        Console.WriteLine("¡Hola! Bienvenido al programa.");
        break;
    case "ingles":
        Console.WriteLine("Hello! Welcome to the program.");
        break;
    case "frances":
        Console.WriteLine("Bonjour ! Bienvenue au programme.");
        break;
    default:
        
        Console.WriteLine("El idioma ingresado no es válido.");
        break;
}
Console.WriteLine("parte 5#");
Console.WriteLine("Ingrese la calificación del examen (0-100):");
calificacion = int.Parse(Console.ReadLine());
if(calificacion % 2 == 0)
{
    Console.WriteLine("la calificacion es un numero par");
}
else
{
    Console.WriteLine("la calidicaicon no es un numero par");
}
switch (calificacion)
{
    case int n when (n >= 95 && n <= 100):
        Console.WriteLine("¡Felicidades! Su desempeño es: Sobresaliente");
        break;
    case int n when (n >= 90 && n <= 94):
        Console.WriteLine("Su desempeño es: Sobresaliente");
        break;
    case int n when (n >= 80 && n <= 89):
        Console.WriteLine("Su desempeño es: Notable");
        break;
    case int n when (n >= 70 && n <= 79):
        Console.WriteLine("Su desempeño es: Aprobatoria");
        break;
    case int n when (n >= 60 && n <= 69):
        Console.WriteLine("Su desempeño es: No aprobatoria");
        break;
    case int n when (n < 60):
            Console.WriteLine("Su desempeño es: Deficiente. Debe estudiar más para aprobar el examen.");
        break;
}

