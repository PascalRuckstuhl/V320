namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test 1

            // Das Wort was getestet Wird.
            string word = "racecar";

            // Instanzen erstellen
            PalindromeChecker checker = new PalindromeChecker();
            bool isPalindrome = checker.IsPalindrome(word);

            // Ausgabe
            Console.WriteLine("{0} is a palindrome: {1}", word, isPalindrome);


            
            //Test 2

            // Das Wort was getestet Wird.
            string word2 = "lagerregal";

            // Instanzen erstellen
            PalindromeChecker checker2 = new PalindromeChecker();
            bool isPalindrome2 = checker.IsPalindrome(word2);

            // Ausgabe
            Console.WriteLine("{0} is a palindrome: {1}", word2, isPalindrome2);



            //Test 3

            // Das Wort was getestet Wird.
            string word3 = "hannah";

            // Instanzen erstellen
            PalindromeChecker checker3 = new PalindromeChecker();
            bool isPalindrome3 = checker.IsPalindrome(word3);

            // Ausgabe
            Console.WriteLine("{0} is a palindrome: {1}", word3, isPalindrome3);


            //Test 4

            // Das Wort was getestet Wird.
            string word4 = "35553";

            // Instanzen erstellen
            PalindromeChecker checker4 = new PalindromeChecker();
            bool isPalindrome4 = checker.IsPalindrome(word4);

            // Ausgabe
            Console.WriteLine("{0} is a palindrome: {1}", word4, isPalindrome4);


            //Test 5

            // Das Wort was getestet Wird.
            string word5 = "hello";

            // Instanzen erstellen
            PalindromeChecker checker5 = new PalindromeChecker();
            bool isPalindrome5 = checker.IsPalindrome(word5);

            // Ausgabe
            Console.WriteLine("{0} is a palindrome: {1}", word5, isPalindrome5);
        }
    }
}