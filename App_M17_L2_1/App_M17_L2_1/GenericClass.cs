namespace App_M17_L2_1
{
    interface MyInterface
    {
        void Run();
    }

    class MyClass : MyInterface
    {
        public void Run()
        {
            return;
        }
    }

    class GenericClass
    {
        public void Show<T>(T value)
        {
            value.ToString();
        }

        public void Run<T>(T value)
            where T: MyInterface
        {
            value.Run();
        }

    }
}
