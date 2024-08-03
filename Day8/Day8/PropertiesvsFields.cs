using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    //properties vs fields

    public class Sample
    {
        public int _demo; //field
        public int Demo { get; set; } //property

        //field
        private string _defaultDiscount;
        public Sample() 
        {
            _defaultDiscount = "10%";
        }
        public string Myfield { get { return _defaultDiscount; } set { _defaultDiscount = value; } }

        //Auto property
        public int MyProperty { get; set; }
    }
    internal class PropertiesvsFields
    {
        public static void Main2()
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.Myfield);
        }
    }
}
