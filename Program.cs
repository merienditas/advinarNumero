
public class Program
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        int NumeroUsuario = 0; 
    
        Console.Title = "ADIVINACIÓN Y OTRAS COSAS"; 

        Console.WriteLine ("¡HOLA! Bienvenidx a nuestro programa.");
        Console.WriteLine("Debe adivinar en qué numero estoy pensando del 0 al 16. *TIENE 3 INTENTOS*. "); 
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        MenuIntentos();
        if (NumeroUsuario == numeroParaAdivinar)
        {
            Console.WriteLine("¡¡ENHORABUENA!! HAS GANADOOOOOOOOOOOO");
        }
        else
        {
            Console.WriteLine("Lo siento, otra vez será. :( ");
        }
        Console.ReadLine();    
    }

     private static void MenuIntentos()
    {
        Console.WriteLine("Introduzca un número. Éste es su primer intento. ");
        int NumeroUsuario = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Éste es su segundo intento. ");
        NumeroUsuario = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Éste es su tercer y último intento");
        NumeroUsuario = Int32.Parse(Console.ReadLine());    
    } 
}
