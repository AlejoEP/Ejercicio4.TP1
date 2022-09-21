namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            Console.WriteLine("Ingrese otra palabra:");
            string palabra2 = Console.ReadLine();

            string palabranueva = "";
            for (int i = palabra.Length -1; i>=0; i--)
            {
                palabranueva = palabranueva + palabra[i];
            }
            if (palabra == palabra2)
            {
                Console.WriteLine("Son palindromos");
                
            }
            else
            {
                Console.WriteLine("No son palindromos");
            }
        }
    }
}