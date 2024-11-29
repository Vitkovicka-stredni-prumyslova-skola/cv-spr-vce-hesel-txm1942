namespace Obdelnik
{

    class Program
    {
        public static void Main(String[] args){
            Console.WriteLine(Heslo.maxDelkaHesla);

            Heslo mojeHeslo = new Heslo();

            Console.WriteLine(mojeHeslo.MaxDelkaHesla());
        }
    }

}
