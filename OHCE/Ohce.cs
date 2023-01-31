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
    public string Miroir (string input)
    {
        StringBuilder stringBuilder = new StringBuilder();
        string inversee = new string( input.Reverse().ToArray());
        stringBuilder.Append(inversee);
        return stringBuilder.ToString();
    }
    public string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();

        
        if (this.Miroir(input) == input )
            stringBuilder.Append(_langue.BienDit);

        return stringBuilder.ToString();
    }
    public string Saluer()
    {
        return this._langue.DireBonjour(this._périodeJournée);
    }
    public string DireAuRevoir()
    {
        return this._langue.DireAuRevoir(this._périodeJournée);
    }
}