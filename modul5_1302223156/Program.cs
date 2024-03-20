namespace modul5_1302223156
{
    class penjumlahan<T>
    {
        public void JumlahTigaAngka(T a, T b, T c)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            dynamic c1 = c;

            dynamic hasil = a1 + b1 + c1;
            Console.WriteLine(hasil);
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void addNewData(T input)
        {
            storedData.Add(input);
            inputDates.Add(DateTime.Now);
        }
        public void printAllData()
        {
            for (int i = 0; i < storedData.Count ; i++)
            {
                Console.WriteLine("Data " + i + "berisi " + storedData[i]+", "+ "Pada waktu " + inputDates[i]);
            }
        }

        
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            penjumlahan<int> NIM = new penjumlahan<int>();
            NIM.JumlahTigaAngka(13, 2, 22);

            SimpleDataBase<int> a = new SimpleDataBase<int>();
            a.addNewData(13);
            a.addNewData(02);
            a.addNewData(22);
            a.printAllData();
        }
    }
}