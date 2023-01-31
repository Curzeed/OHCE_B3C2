
using System.Globalization;


namespace OHCE.Console
{
    public class SystemLangueProxy
    {
        public ILangue _langue;
        public ILangue getLangue(string twoLetterISOLanguageName)
        {
            
            if (twoLetterISOLanguageName == "fr")
            {
                _langue = new Langues.LangueFrançaise();
            }
            else
            {
                _langue = new Langues.LangueAnglaise();
            }
            return _langue;
        }
    }
        
}
