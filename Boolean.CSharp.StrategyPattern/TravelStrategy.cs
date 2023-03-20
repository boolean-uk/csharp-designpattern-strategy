namespace Boolean.CSharp.StrategyPattern
{
    public abstract class TravelStrategy
    {
        public int KilometerCost;
        public abstract decimal Drive(int kilometers);
    }
}