
using System;
namespace day3
{
    //storage => real : int , img : int  members 
    //validation => img >=0
    //operation => print ,+,-,==,methods
    struct complexnumber
    {
        #region prop & dynamic prop
        //define member
        // validation => member + prop
        //no validation => dynamic prop
         public int Real { get; set; } ///dynamic prop replace variable & property
        //int real;
        int img;
        public int Img
        {
            set
            {
                if (value >= 0)
                    img = value;
                else
                    img = 0;
            }
            get { return img; }
        }
        public void print()
        {
            Console.WriteLine($"{Real}+{img}i");
        }
            
        

        
        //public int Real // propery 
        //{
        //    get { return real; }
        //    set { real = value; }
        //}
        #endregion
        #region struct setter & getter 
        //// struct setter & getter // دا الشكل الي بيطلع il
        ////public void set_img(int _img) 
        ////{
        ////    // prop

        ////    if (_img >= 0)
        ////    {
        ////        img=_img;
        ////    }
        ////    else
        ////    {
        ////        img =0;
        ////    }
        ////}

        ////public int get_img()
        ////{
        ////    return img;
        ////}
        //public void set_real(int _real)
        //{
        //    real = _real;
        //}
        //public int get_real()
        //{
        //    return real;
        //}
        #endregion
    }
    #region polymorphism overload
    struct calc
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public float sum(float num1, float num2)
        {
            return num1 + num2;
        }
    }
    #endregion

    #region lab
    struct time
    {
        int hours, minutes, seconds;
        public int Hours
        {
            set
            {
                if ((value >= 0) && (value <= 24))
                {
                    hours = value;
                }
                else
                    hours = 0;
            }
            get { return hours; }
        }
        public int Minutes { 
            set
            {
                if ((value >= 0) && (value <= 60))
                {
                    minutes = value;
                }
                else { 
                    minutes = 0;
                    if(hours ==24)
                    {
                        hours = 1;
                    }
                    else
                    hours++;
                }
            }
            get { return minutes; }
        }
        public int Seconds
        {
            set
            {
                if ((value >= 0) && (value <= 60))
                {
                    seconds = value;
                }
                else
                {
                    seconds = 0;
                    if (minutes == 60)
                    {
                        minutes = 1;
                    }
                    else
                    minutes++;
                }
            }
            get { return seconds; }
        }
        public void print()
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
    #endregion
    class program
    {
        static void Main()
        {
            #region foreach from day 2
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 9 };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region user defined datatypes
            // datatype => storage , validation , operation

            //ways to create user defined datatype

            //struct //complex value datatype , used for small size complex datatype
            //class //complex reference datatype , used for large size complex datatype
            //enum // define datatype with exact values
            //interface // used with abstract , top level of abstract , reference datatype
            //delgate // pointer to function , reference datatype
            //recoed // immutable datatype , reference datatype

            #endregion
            #region struct with setter & getter
            //complex numbers
            //storage => real : int , img : int  members 
            //validation => img >=0
            //operation => print ,+,-,==,methods
            //complexnumber x;//valuedate type
            // if variables public
            //x.real = 3;
            //x.img = 2;
            //Console.WriteLine($"{x.real}+{x.img}i");

            //complexnumber x2;
            //x2.real = 2;
            //x2.img = 3;
            //Console.WriteLine($"{x2.real}+{x2.img}i");

            // complexnumber c = new complexnumber();
            // c.set_real(5);

            // c.set_img(-5);// img =0 because of validation
            //Console.WriteLine($"{c.get_real()}+{c.get_img()}i");

            //complexnumber c= new complexnumber();
            //c.set_real(1);
            //int x= c.get_real();
            //x++;
            //c.set_real(x);


            #endregion
            #region prop , dynamic prop
            //complexnumber n;
            //n.Img // get
            //n.Img=3 // set

            //complexnumber c= new complexnumber();
            //c.Img = 1;
            //c.Img++;
            //c.Real = 5;
            //Console.WriteLine(c.Img);

            //complexnumber c1 = new complexnumber();
            //c1.Img = -1;
            //c1.Real = 1;
            //Console.WriteLine($"{c1.Real}+{c1.Img}i");
            #endregion
            #region polymorphism overload
            //calc c;

            //Console.WriteLine(c.sum(1, 2));
            //Console.WriteLine(c.sum(1.1f, 2.2f));
            //Console.WriteLine(c.sum(3, 5, 7));
            #endregion

            #region array of complex numbers
            //complexnumber c= new complexnumber();
            //    c.Real = 1;
            //    c.Img = 3;
            //    c.print();

            //arr[0].Real = 5;
            //arr[0].Img=4;
            //arr[0].print();
            // Console.WriteLine("enter number of complex number");
            // int numberOfComplerNum = int.Parse(Console.ReadLine());
            // complexnumber[] arr = new complexnumber[numberOfComplerNum];
            // for (int i = 0; i < numberOfComplerNum; i++)
            // {
            //     Console.WriteLine($"enter real part of number {i + 1}");
            //     arr[i].Real = int.Parse(Console.ReadLine());
            //     Console.WriteLine($"enter img part of number {i + 1}");
            //     arr[i].Img = int.Parse(Console.ReadLine());

            // }
            //foreach(complexnumber i in arr)
            // {
            //     i.print();
            // }
            #endregion
            #region lab
            //task1
            //time t = new time();
            //Console.WriteLine("enter hour");
            //t.Hours = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter minutes");
            //t.Minutes = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter seconds");
            //t.Seconds = int.Parse(Console.ReadLine());
            //t.print();

            //task2
            //Console.WriteLine("enter number of times");
            //int numOftime = int.Parse(Console.ReadLine());
            //time[] array = new time[numOftime];
            //for (int i = 0; i < numOftime; i++)
            //{
            //    Console.WriteLine("enter hour");
            //    array[i].Hours = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter minutes");
            //    array[i].Minutes = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter seconds");
            //    array[i].Seconds = int.Parse(Console.ReadLine());
            //}
            //foreach(time i in array)
            //{
            //    i.print();
            //}


            #endregion
        }
    }
}