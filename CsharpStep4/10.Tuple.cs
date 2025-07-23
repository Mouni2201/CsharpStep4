using System;

namespace TupleNamespace
{
    class ExampleTuple
    {
        static void Main()
        {

            //Basic example
            Tuple<int, string, string> data = Tuple.Create(1, "Medhansh", "Chennai");
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);

            Tuple<string> data1 = Tuple.Create("Banglore");
            Console.WriteLine(data1.Item1);


            //return type (int Id, string Name, string Location)
            //value type tuple
            (int Id, string Name, string Location) studentDetails = (1, "Medhansh", "Chennai");
            Console.WriteLine(studentDetails.Id);
            Console.WriteLine(studentDetails.Name);
            Console.WriteLine(studentDetails.Location);



            //int myID = getID();
            //Console.WriteLine(myID);

            


            (int Id, string Name, string Location)  refemployee = Employee();
            Console.WriteLine(refemployee.Id);
            Console.WriteLine(refemployee.Name);
            Console.WriteLine(refemployee.Location);

            //destructure the Tuple

            var (Id,Name,Location)  = (1, "Medhansh", "Chennai");  //by using var we can destructure the tuple and dat type
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Location);
            //don't use oobject , if you want use you need to unboxing



            //if yiou want to update anything follow like below
            //int eid = 1;
            //if(eid == 1)
            //{
            //    eid = 2;
            //}
            //var (id, Name, Location) = (eid, "Medhansh", "Chennai");  //by using var we can destructure the tuple and dat type
            //Console.WriteLine(id);
            //Console.WriteLine(Name);
            //Console.WriteLine(Location);




        }

        ////return type ->int
        //static int getID()
        //{
        //    return 1;
        //}

        static (int Id, string Name, string Location) Employee()
        {

            return (1, "John", "Banglore");   //here wraping is important
        }


        //we don't add remove or update here we only fetch the data here
        public static (int Id, string Name, string Location) employee()
        {
            int empid = 1;
            string empName = "John";
            string empLocation = "Pune";

            return (empid, empName, empLocation);   //here wraping is important
        }

    }
}

