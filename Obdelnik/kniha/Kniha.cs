namespace Kniha
{
    // Rozhraní pro knihy
    public interface Ikniha
    {
        string Nazev();  
        string Autor(); 
        int RokVydani(); 
        void VypisInformace(); 
    }

    
    public class Kniha : IKniha
    {
        private string nazev;
        private string autor;
        private int rokVydani;

        
        public Kniha(string nazev, string autor, int rokVydani)
        {
            this.nazev = nazev;
            this.autor = autor;
            this.rokVydani = rokVydani;
        }

        public string Nazev()
        {
            return this.nazev;
        }

        public string Autor()
        {
            return this.autor;
        }

        public int RokVydani()
        {
            return this.rokVydani;
        }

    }


  }