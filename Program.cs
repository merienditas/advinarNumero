
public class Program
{
    public static void Main(String[] args)
    {
        const int respuesta = 0;
        int numeroParaAdivinar = 0; 

    
        while (respuesta <16)
        {
            MenuDeEntrada();
            MenuIntentos();

                if (numeroParaAdivinar <= 16 )
                {

                    var generadorAleatorio = new Random();
                    numeroParaAdivinar = generadorAleatorio.Next(0, 16);

                Console.WriteLine($"El número a adivinar era {numeroParaAdivinar}");
                }
      
            break;
        }
    }

    public static void MenuDeEntrada ()
    {
        Console.WriteLine("Adivinación y otras cosas.  ");
        Console.WriteLine("--------------------------");
        Console.WriteLine ("Adivine en qué numero estoy pensando del 0 al 16. Tiene 3 intentos. ");
        Console.WriteLine("--------------------------------------------------------------------");
    }
     private static void MenuIntentos()
    {
        Console.WriteLine("Introduzca un número. Éste es su primer intento. ");
        int respuesta = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Éste es su segundo intento. ");
        respuesta = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Éste es su tercer y último intento");
        respuesta = Int32.Parse(Console.ReadLine());    
    } 
}
