namespace Konu_14_Arayüzler_INTERFACES
{
    interface Arayüz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }
        
    }

    interface IDemo
    {
        void Goster(); // interface sadece bu kadar yazılır metot tanımlanmaz
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KONU 14: ARAYÜZLER-INTERFACES");
        }
    }
}
