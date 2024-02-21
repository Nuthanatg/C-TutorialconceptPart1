using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PART-63 Partial Methods in c#
namespace PartialMethodsDemo
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        //partial void SamplePartialMethod(int i);

        partial void SamplePartialMethod()//we cannot do implementation withod definition 1st in partial method
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
