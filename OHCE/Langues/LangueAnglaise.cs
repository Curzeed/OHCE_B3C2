namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.WellSaid;
        
        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période)
        {
            return période switch
            {
                PériodeJournée.Defaut => Expressions.English.Hello,
                PériodeJournée.Soir => Expressions.English.GoodEvening,
                PériodeJournée.AprèsMidi => Expressions.English.GoodAfternoon,
                PériodeJournée.Matin => Expressions.English.GoodMorning,
                PériodeJournée.Nuit => Expressions.English.GoodNight,
                _ => "Hello from undefined period",
            };
        }

        public string DireAuRevoir(PériodeJournée période)
        {
            return période switch
            {
                PériodeJournée.Defaut => Expressions.English.GoodBye,
                PériodeJournée.Matin => Expressions.English.GoodMorning,
                PériodeJournée.AprèsMidi => Expressions.English.GoodAfternoon,
                PériodeJournée.Soir => Expressions.English.GoodEvening,
                PériodeJournée.Nuit => Expressions.English.GoodEvening,
                _ => Expressions.English.GoodBye,
            };
        }
    }
}
