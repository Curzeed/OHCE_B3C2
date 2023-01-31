using System.Text;


namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();

        var reversed = new string(
            input.Reverse().ToArray()
        );

        if (reversed.Equals(input))
            stringBuilder.Append(reversed + " est bien un palindrome !"+ "\n" + _langue.BienDit + "\n");

        stringBuilder.Append(_langue.AuRevoir);

        return stringBuilder.ToString();
    }
    public string Saluer()
    {
        return this._langue.SayHello(this._périodeJournée);
    }
}