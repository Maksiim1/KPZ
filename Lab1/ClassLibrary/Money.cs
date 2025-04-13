using System;

namespace ClassLibrary
{
    public class Money
    {
        public int Whole { get; private set; }
        public int Fraction { get; private set; }

        public Money(int whole, int fraction)
        {
            Whole = whole + fraction / 100;
            Fraction = fraction % 100;
        }

        public void SetAmount(int whole, int fraction)
        {
            Whole = whole + fraction / 100;
            Fraction = fraction % 100;
        }

        public override string ToString() => $"{Whole}.{Fraction:D2}";

        public Money Subtract(Money other)
        {
            int thisTotal = ToCents();
            int otherTotal = other.ToCents();

            if (otherTotal > thisTotal)
                throw new InvalidOperationException("Amount can't be negative");

            int resultCents = thisTotal - otherTotal;
            return new Money(resultCents / 100, resultCents % 100);
        }

        public int ToCents() => Whole * 100 + Fraction;
    }
}
