using System;
//using System.Globalization;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//SimpleCode


namespace lessons
{
    class Program
    {
        public static void Resize<T>(ref T[] arr, int add)
        {
            T[] tempArray = new T[arr.Length];
            int length;

            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }

            length = arr.Length + add;

            if (length >= 0)
                arr = new T[length];
            else
                length = 0;
                arr = new T[length];
            
            length = tempArray.Length < arr.Length ? length = tempArray.Length : length = arr.Length;

            for (int i = 0; i < length; i++)
            {
               
                 arr[i]=tempArray[i];
            }
        }

        private static void Resize2(ref int[] arr, int index)
        {
            if(index<0)
            
                index=0;
            
            int[] tempArr = new int[arr.Length + index];

            for (int i = index; i < tempArr.Length; i++)
            {
                 tempArr[i]=arr[i - index];
            }

            arr = tempArr;
        }

        static void Main(string[] args)
        {

            int[] myArray = new int[] { 12, 34, 45, 66, 34, 32, 66, 102, 20, 66, 66, 66, 45, 23, 11 };
            //string[] myStrArray = { "fuck", "Meow", "bylByl" };

            //int add = -3;


            //Resize(ref myStrArray,add);


            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write( myArray[i] + "  ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < myStrArray.Length; i++)
            //{
            //    Console.Write(myStrArray[i] + "  ");
            //}


            

            //Resize2(ref myArray, index);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + "  ");
            //}

            Console.WriteLine();

            int element = 66;

            //int index=-1;

            Resize3(ref myArray, element);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "  ");
            }
            Console.WriteLine();


            Console.Read();
        }

        private static void Resize3(ref int[] myArray, int element)
        {
            int count = 0;

            int x=0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == element)
                {
                    x = i;
                    count++;
                    break;
                }
                    
               
            }
            if (count == 0)
                return;
            int[] newArray = new int[myArray.Length -1];
            if(x==0)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                newArray[i] = myArray[i+1];
                }

            }
            else
            {
                for (int i = 0; i < x; i++)
                {
                    newArray[i] = myArray[i];
                }

                for (int i = x+1; i < myArray.Length; i++)
                {
                    newArray[i-1] = myArray[i];
                }



            }
            myArray = newArray;
            Resize3(ref myArray, element);
        }
    }

}

