using System.Reflection.Metadata.Ecma335;

namespace Assignment1
{
    public class Arithmetic
    {
        public int num1 { get; set; }
        public int num2 { get; set;}
        
        public int Sub()
        { 
        int res;
        res=num1- num2;
            return res;
        }
        public int Multi()
        {
        int res;
        res = num1* num2;
            return res;
        }
        public int Div()
        {
        int res;
        res = num1/ num2;
            return res;
        }
        
    }
}
