namespace ejercicio7Array
{

    class Program
    {

        public static void Main(string[] args)
        {

            int[] listaEnteros1 = { 10, 45, 60, 6, 7, 3, 2, 10 };
            int[] listaEnteros2 = { 45, 56, 2, -1, 98, 34 };

            Console.WriteLine("Longuitud de la lista");
            Console.WriteLine(listaEnteros1.Length);

            //Obtener primera, penultima y ultima posicion
            Console.WriteLine(" ");
            Console.WriteLine("Obtener primera, penultima y ultima posicion");
            Console.WriteLine(listaEnteros1[0]);
            Console.WriteLine(listaEnteros1[6]);
            Console.WriteLine(listaEnteros1[7]);

            //Ordenar de forma ascendente
            Console.WriteLine(" ");
            Console.WriteLine("Ordenar de forma ascendente");
            Array.Sort(listaEnteros1);
            foreach (int i in listaEnteros1)
            {
                Console.WriteLine(i);
            }

            //Modificar ultima posicion
            listaEnteros1[7] = 100;

            //Ordenar de forma descendente
            Console.WriteLine(" ");
            Console.WriteLine("Ordenar de forma descendente");
            Array.Reverse(listaEnteros1);
            foreach (int i in listaEnteros1)
            {
                Console.WriteLine(i);
            }

      
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Longuitud de la lista");
            Console.WriteLine(listaEnteros2.Length);

            Console.WriteLine(" ");
            Console.WriteLine("Obtener penultima, primera y ultima posicion");
            Console.WriteLine(listaEnteros2[4]);
            Console.WriteLine(listaEnteros2[0]);
            Console.WriteLine(listaEnteros2[5]);


        }
    }
}