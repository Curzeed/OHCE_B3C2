

namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période)
        {
            return période switch
            {
                PériodeJournée.Defaut => Expressions.Français.Bonjour,
                PériodeJournée.Matin => Expressions.Français.Bonjour,
                PériodeJournée.AprèsMidi => Expressions.Français.BonAprèsMidi,
                PériodeJournée.Soir => Expressions.Français.Bonsoir,
                PériodeJournée.Nuit => Expressions.Français.BonneNuit,
                _ => "Bonjour dans votre période inconnue !",
            };
        }
        public string DireAuRevoir(PériodeJournée période)
        {
            return période switch
            {
                PériodeJournée.Defaut => Expressions.Français.AuRevoir,
                PériodeJournée.Matin => Expressions.Français.Bonjour,
                PériodeJournée.AprèsMidi => Expressions.Français.BonAprèsMidi,
                PériodeJournée.Soir => Expressions.Français.Bonsoir,
                PériodeJournée.Nuit => Expressions.Français.BonneNuit,
                _ => Expressions.Français.AuRevoir,
            };
        }
    }
}
