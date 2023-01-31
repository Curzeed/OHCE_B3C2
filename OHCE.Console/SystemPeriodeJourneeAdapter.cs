using System.Globalization;

namespace OHCE.Console
{
    public class SystemPeriodeJourneeAdapter
    {
        private PériodeJournée _périodeJournée;

        public PériodeJournée getPériode(DateTime date)
        {
            if (date.Hour < 11 && date.Hour > 6)
            {
                this._périodeJournée = PériodeJournée.Matin;
            }
            if (date.Hour > 12 && date.Hour < 17)
            {
                this._périodeJournée = PériodeJournée.AprèsMidi;
            }
            if (date.Hour > 18 && date.Hour < 23)
            {
                this._périodeJournée = PériodeJournée.Soir;
            }
            if(date.Hour > 23 && date.Hour < 5)
            {
                this._périodeJournée = PériodeJournée.Nuit;
            }
            return this._périodeJournée;
        }
    }
}
