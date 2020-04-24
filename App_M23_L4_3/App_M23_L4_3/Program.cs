namespace App_M23_L4_3
{
    // PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            var baseObject = new BaseClass();
            IBaseType someObject = baseObject;

            someObject.FancyMethod();

            // Dekorujemy obiekt, przez co przy używaniu funkcji dodajemy nowe instrukcje
            someObject = new AnotherDecorator(new Decorator(baseObject));

            someObject.FancyMethod();
        }
    }
    
    // Interfejs
    interface IBaseType
    {
        void FancyMethod();
        int Calculate(int a);
    }

    // Klasa, którą będziemy dekorować
    class BaseClass : IBaseType
    {
        public void FancyMethod()
        {
            // DO SOMETHING
        }

        public int Calculate(int a)
        {
            return a * 2;
        }
    }

    // Pierwszy dekorator
    class Decorator : IBaseType
    {
        private IBaseType baseObject;

        // Bierzemy obiekt, który będziemy dekorować
        public Decorator(IBaseType baseObj)
        {
            baseObject = baseObj;
        }

        // Dodajemy coś od siebie ale ostatecznie używamy tego obiektu dekorowanego
        public void FancyMethod()
        {
            var logger = Logger.Instance();
            logger.log("FancyMethod called");
            baseObject.FancyMethod();
        }

        // Dodajemy coś od siebie ale ostatecznie używamy tego obiektu dekorowanego
        public int Calculate(int a)
        {
            var modified = a + 2;

            return baseObject.Calculate(modified);
        }
    }

    // Drugi dekorator
    class AnotherDecorator : IBaseType
    {
        private IBaseType baseObject;

        // Bierzemy obiekt, który będziemy dekorować
        public AnotherDecorator(IBaseType baseObj)
        {
            baseObject = baseObj;
        }

        // Dodajemy coś od siebie ale ostatecznie używamy tego obiektu dekorowanego
        public void FancyMethod()
        {
            baseObject.FancyMethod();
        }

        // Dodajemy coś od siebie ale ostatecznie używamy tego obiektu dekorowanego
        public int Calculate(int a)
        {
            var modified = a + 5;

            return 2 + baseObject.Calculate(modified);
        }
    }
}
