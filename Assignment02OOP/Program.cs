namespace Assignment02OOP
{
    internal class Program
    {
        #region function of Q2

        //static double DistanceBetweemPoints(Point point1,Point point2)
        //{
        //    double distance;
        //    distance= Math.Sqrt(Math.Pow(point2.X - point1.X, y:2) + Math.Pow(point2.Y - point1.Y,y:2 ) );
        //    return distance;
        //}

        #endregion
        static void Main(string[] args)
        {

            #region Q1



            //Person[]? person= {new Person(),new Person(),new Person()};

            //int age;

            //string? name;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data of the person {i + 1} ");
            //  ;
            //    name = Console.ReadLine();
            //    person[i].Name = name;
            //    int.TryParse(Console.ReadLine(), out age);
            //    person[i].Age = age;
            //}

            //Console.Clear();
            //for (int i = 0; i < 3; i++)
            //{

            //    Console.WriteLine($"Data of person {i + 1} is  name: {person[i].Name} & age: {person[i].Age}");

            //} 
            #endregion

            #region Q2

            // double result;
            // int x , y;
            // Point p1 = new Point(5,6);

            // Point p2= new Point();
            // int.TryParse(Console.ReadLine(), out x);
            // p2.X = x;
            // int.TryParse(Console.ReadLine(), out y);    
            // p2.Y= y;

            //result= DistanceBetweemPoints(p1, p2);

            // Console.WriteLine(result);

            #endregion


            #region Q3


            //int size;
            //Console.WriteLine("Enter the number of persons");
            //int.TryParse(Console.ReadLine(), out size);
            //Person2[] personObj= new Person2[size];


            //int age;

            //Person2 container;
            //for (int i = 0; i < personObj.Length; i++) 
            //{
            //    Console.WriteLine($"Enter the data of the person {i+1} ");
            //    personObj[i]= new Person2();
            //    Console.WriteLine("Name :");
            //    personObj[i].Name = Console.ReadLine();

            //    Console.WriteLine("age :");
            //    int.TryParse(Console.ReadLine(), out age);
            //    personObj[i].Age = age; 
            //}

            //Console.Clear();

            //foreach(Person2 person in personObj)
            //{
            //    Console.WriteLine(person);
            //}


            //// after  sorting descinding
            //Console.WriteLine("**************************************");

            //for (int i = 0; i < personObj.Length; i++)
            //{
            //      for(int j = 1; j < personObj.Length; j++) 
            //      {
            //        if(personObj[i].Age < personObj[j].Age)
            //        {
            //            container = personObj[i];
            //            personObj[i] = personObj[j] ;
            //            personObj[j] = container ;
            //        }

            //      }
            //}

            //Person2 oldestPerson = personObj[0];
            //Console.WriteLine($"Oldest {oldestPerson}");



            #endregion

            #region Q4


            //Rectangle rectangleObj = new Rectangle();
            //Console.WriteLine("Enter the dimensions of the rectangle :");
            //Console.WriteLine("Width = ");
            //rectangleObj.Width = double.Parse(Console.ReadLine());
            //Console.WriteLine("Height = ");
            //rectangleObj.Height = double.Parse(Console.ReadLine());
            //rectangleObj.DisplayInfo();
            //Console.WriteLine(rectangleObj.Area);

         

            #endregion
        }
    }
}
