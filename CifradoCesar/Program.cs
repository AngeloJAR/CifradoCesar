using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("BIENVENIDO A ENCRIPTACION CON EL METODO DE JULIO CESAR EL EMPERADOR ");
            Console.WriteLine("Elija una de las siguientes opciones segun lo que desee hacer,");
            Console.WriteLine("ya sea encriptar o desencriptar un mensaje");
            Console.WriteLine("Dijite 1 para encriptar");
            Console.WriteLine("Dijite 2 para desencriptar");
            Console.WriteLine("Dijite 3 para salir");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EncriptarMensaje();
                    break;
                case "2":
                    DesencriptarMensaje();
                    break;

                case "3":
                    Console.WriteLine("Saliendo del programa");
                    return;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
    static void EncriptarMensaje() 
    {
        Console.WriteLine("Ingrese el mensaje a encriptar");
        string MensajeOriginal = Console.ReadLine().ToUpper();
        Console.WriteLine("Ingrese la clave");
        int clave = int.Parse(Console.ReadLine());

        string MensajeEncriptado = Encriptar(MensajeOriginal, clave);
        Console.WriteLine("El mensaje encriptado es:" +  MensajeEncriptado);

    }
    static void DesencriptarMensaje()
    {
        Console.WriteLine("Ingrese el mensaje a desencriptar");
        string MensajeDesencriptar = Console.ReadLine().ToUpper();
        Console.WriteLine("Ingrese la clave");
        int claveDesencriptar = int.Parse(Console.ReadLine());

        string Mensaje = Desencriptar(MensajeDesencriptar, claveDesencriptar);
        Console.WriteLine("El mensaje desencriptado es:" + Mensaje);
    }

    static string Encriptar(string mensaje, int clave)
    {
        string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string mensajeEncriptado = ""; 

        foreach (char letra in mensaje) // Iteramos sobre cada letra del mensaje original
        {
            if (abecedario.Contains(letra)) // Verificamos si la letra está en el abecedario
            {
                int indiceOriginal = abecedario.IndexOf(letra); // Obtenemos el índice de la letra en el abecedario
                int indiceEncriptado = (indiceOriginal + clave) % abecedario.Length; // Calculamos el nuevo índice encriptado sumando la clave
                mensajeEncriptado += abecedario[indiceEncriptado]; // Agregamos la letra encriptada al mensaje encriptado
                //Console.WriteLine("Indice Origina:" + indiceOriginal);
                //Console.WriteLine("Indice encriptado:" + indiceEncriptado);
                //Console.WriteLine("Clave :" + clave);
            }
            else
            {
                mensajeEncriptado += letra; // Si la letra no está en el abecedario, la agregamos tal cual al mensaje encriptado
            }
        }
                
        return mensajeEncriptado; // Devolvemos el mensaje encriptado
    }

    static string Desencriptar(string mensajeaDesencriptar, int clave)
    {
        string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string MensajeDesencriptar = "";

        foreach (char letra in mensajeaDesencriptar) // Iteramos sobre cada letra del mensaje original
        {
            if (abecedario.Contains(letra)) // Verificamos si la letra está en el abecedario
            {
                int indiceOriginal = abecedario.IndexOf(letra); // Obtenemos el índice de la letra en el abecedario
                int indiceEncriptado = (indiceOriginal - clave) % abecedario.Length; // Calculamos el nuevo índice encriptado sumando la clave
                MensajeDesencriptar += abecedario[indiceEncriptado]; // Agregamos la letra encriptada al mensaje encriptado
                //Console.WriteLine("Indice Origina:" + indiceOriginal);
                //Console.WriteLine("Indice encriptado:" + indiceEncriptado);
                //Console.WriteLine("Clave :" + clave);
            }
            else
            {
                MensajeDesencriptar += letra; // Si la letra no está en el abecedario, la agregamos tal cual al mensaje encriptado
            }
        }

        return MensajeDesencriptar; // Devolvemos el mensaje encriptado
        // El proceso de desencriptar es similar al de encriptar, pero con la clave negativa
    }
}
