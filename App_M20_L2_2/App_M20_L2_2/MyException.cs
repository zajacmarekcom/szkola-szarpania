using System;

namespace App_M20_L2_2
{
    class MyException : Exception
    {
        public MyException() : base()
        {
        }

        public MyException(string message) : base(message)
        {
        }
    }
}
