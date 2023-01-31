using OHCE;
using OHCE.Console;
using OHCE.Langues;
using System.Globalization;

Console.WriteLine("Hello, World!");
var ohce = new Ohce(new SystemLangueProxy().getLangue(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName), new SystemPeriodeJourneeAdapter().getPériode(DateTime.Now));
Console.WriteLine(ohce.Saluer());
Console.WriteLine(" > ");
var input = Console.ReadLine(); 
Console.WriteLine(ohce.Miroir(input));
Console.WriteLine(ohce.Palindrome(input));
Console.WriteLine(ohce.DireAuRevoir());