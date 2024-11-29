namespace Obdelnik
{
    interface IHeslo
    {
        int DelkaHesla();
        int MaxDelkaHesla();
        int MinDelkaHesla();
    }

    class Heslo : IHeslo
    {
        private string heslo;
        public static int maxDelkaHesla = 20;
        private static int minDelkaHesla = 8;

        string malaPismena = "abcdefghijklmnopqrstuvwxyz";
        string velkaPismena = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialniZnaky = "!@#$%^&*()-_=+[]{}\\|;:'\",.<>/?`~";
        string cislovky = "0123456789";

        public int DelkaHesla()
        {
            return heslo.Length;
        }

        public int MaxDelkaHesla()
        {
            return maxDelkaHesla;
        }

        public int MinDelkaHesla()
        {
            return minDelkaHesla;
        }

        public static string GeneratorHesla(int pocetZnakuHesla)
        {
        

        
        }
    }
    