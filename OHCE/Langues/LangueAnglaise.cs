namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.WellSaid;
        
        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période)
        {
            switch (période)
            {
                case PériodeJournée.Defaut: return Expressions.English.Hello;
                case PériodeJournée.Soir: return Expressions.English.GoodEvening;
                case PériodeJournée.AprèsMidi: return Expressions.English.GoodAfternoon;
                case PériodeJournée.Matin: return Expressions.English.GoodMorning;
                case PériodeJournée.Nuit: return Expressions.English.GoodNight;
                default: return "Hello from undefined period";
            }
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.GoodBye;
    }
}
