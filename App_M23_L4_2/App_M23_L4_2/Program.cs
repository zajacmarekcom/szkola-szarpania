namespace App_M23_L4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDiscountStrategy strategy;

            // Wybór strategii
            if (user.IsPremium)
            {
                strategy = new PremiumDiscountStrategy();
            }
            else
            {
                strategy = new StandardDiscountStrategy();
            }

            var invoiceProcessor = new InvoiceProcessor(strategy);
        }
    }

    // Interfejs strategii
    interface IDiscountStrategy
    {
        decimal DiscountValue(decimal totalOrderValue);
    }

    // Konkretna strategia
    class StandardDiscountStrategy : IDiscountStrategy
    {
        public decimal DiscountValue(decimal totalOrderValue)
        {
            if (totalOrderValue < 500.0M)
            {
                return 0.0M;
            }

            return totalOrderValue * 0.05M;
        }
    }

    // Konkretna strategia
    class PremiumDiscountStrategy : IDiscountStrategy
    {
        public decimal DiscountValue(decimal totalOrderValue)
        {
            return totalOrderValue * 0.1M;
        }
    }

    // Użytkownik strategii
    class InvoiceProcessor
    {
        private IDiscountStrategy _discountStrategy;

        public InvoiceProcessor(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public Invoice Process(IList<Item> items)
        {
            var sum = items.Sum(x => x.Value);

            var discount = _discountStrategy.DiscountValue(sum);
            var total = sum - discount;

            return new Invoice(items, total, discount);
        }
    }
}
