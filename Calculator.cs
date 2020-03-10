class Calculator
{
	static void Main(String[] args)
	{
		int a = 9;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan   "+ a + " + " + b + " = " + penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan  {0} - {1} = {2}", a, b, pengurangan(a, b));
		
		Console.WriteLine("\nTekan Sembarang Untuk keluar");
        Console.ReadKey();
	}
	
	static int penambahan (int a , int b)
    {
            return a + b;
    }
	
	static int pengurangan (int a, int b)
    {
            return a - b;
    }
}