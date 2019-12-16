using System;

namespace OOP_Bucket_Applicatie
{

    public abstract class Program
    {


        abstract class Bucket
        {
            public abstract int bucket { get; set; }
            public abstract int container { get; set; }
            public abstract int bucketinhoud { get; set; }
            public abstract int amountofbuckets { get; set; }
        }


        class Bucket2: Bucket
        {
            Bucket bucketobject = new Bucket();

        }

        abstract class RainBarrel
        {

            public int rainbarrel { get; set; }

            public bool Small { get; set; }

            public bool Medium { get; set; }

            public bool Big { get; set; }

            public int container { get; set; }

            public int rainbarrelamount { get; set; }

        }

        abstract class OilBarrel
        {
            public int oilbarrel { get; set; }

            public int container { get; set; }

            public int oilbarrelamount { get; set; }

        }

        public class subclass2: SubClass
        {
    
            
            public static void method(): base()
            {
                
                SubClass something = new SubClass();
              
            }

        }
    }
}

