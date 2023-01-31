using OHCE;
using OHCE.Console;
using OHCE.Langues;
using System.Globalization;

Console.WriteLine("Hello, World!");
var ohce = new Ohce(new SystemLangueProxy().getLangue(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName), new SystemPeriodeJourneeAdapter().getPériode(DateTime.Now));
Console.WriteLine(ohce.Saluer());
Console.WriteLine(" > ");
Console.WriteLine(ohce.Palindrome(Console.ReadLine()));
Console.WriteLine(ohce.DireAuRevoir);