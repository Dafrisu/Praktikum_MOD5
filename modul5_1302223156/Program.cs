namespace modul5_1302223156 { 
class penjumlahan<T> {
        public void JumlahTigaAngka(T a, T b, T c) {
            dynamic a1=a;
            dynamic b1=b;
            dynamic c1=c;

            dynamic hasil = a1 + b1 + c1;
            Console.WriteLine(hasil);
        }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            penjumlahan<int> NIM = new penjumlahan<int>();
            NIM.JumlahTigaAngka(13, 22, 21);
        }
    }
}
