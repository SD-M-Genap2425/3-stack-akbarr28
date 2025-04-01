using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();
        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine("Halaman saat ini: " + history.LihatHalamanSaatIni());
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        history.Kembali();
        Console.WriteLine("Halaman saat ini: " + history.LihatHalamanSaatIni());

        Console.WriteLine("\nMenampilkan history:");
        history.TampilkanHistory();


        // Bracket validator
        BracketValidator validator = new BracketValidator();
        string ekspresiValid = "{[()]}";
        string ekspresiInvalid = "{[(])}";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");
    

        //Palindrome Checker
        string[] testCases = { "Kasur ini rusak", "A man, a plan, a canal: Panama", "Hello World", "" };

        foreach (var test in testCases)
        {
            Console.WriteLine($"'{test}' adalah palindrom? {PalindromeChecker.CekPalindrom(test)}");
        }
        

    }
}
