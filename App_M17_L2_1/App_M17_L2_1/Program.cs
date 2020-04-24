namespace App_M17_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var intObj = new GenericClass<int>();

            //intObj.Field = 22;
            //int intValue = intObj.Field;



            //var stringObj = new GenericClass<string>();

            //stringObj.Field = "Tekst";
            //string stringValue = stringObj.Field;

            var obj = new GenericClass();

            obj.Show<int>(11);

            obj.Run<MyClass>(new MyClass());
        }
    }
}
