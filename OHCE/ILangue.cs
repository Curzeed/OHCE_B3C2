namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string SayHello(PériodeJournée période);
        string AuRevoir { get; }
    }
}
