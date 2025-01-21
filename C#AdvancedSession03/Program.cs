using System.Collections;

namespace C_AdvancedSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non - Generic Collections
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Count Of ArrayList ={arrayList.Count}");
            //Count=> Actuall Number Of Elements In Arraylist
            Console.WriteLine($"Count Of ArrayList ={arrayList.Capacity}");
            //Capacity =>Numbers Of Elements That ArrayList Can Hold
            arrayList.Add(1);
            //adding the First Element To The List The Capacity is 
            //Increased To _defaultCapacity //4
            //New Array Created At Heap With Size 4
            //Console.WriteLine("After adding Frist Element");
            //Console.WriteLine($"Count Of ArrayList ={arrayList.Count}");//1
            //Console.WriteLine($"Count Of ArrayList ={arrayList.Capacity}");//4
            //arrayList.Add(2);
            //arrayList.AddRange(new int[]{3, 4});
            //Console.WriteLine($"Count Of ArrayList ={arrayList.Count}");

            //Console.WriteLine($"Count Of ArrayList ={arrayList.Capacity}");
            //arrayList.Add(5);
            ////Creatw a New Array At Heap With Double Size =8
            ////Take Old Element And Adding New Element => To The New Array
            //Console.WriteLine($"Count Of ArrayList ={arrayList.Count}");//5
            //Console.WriteLine($"Count Of ArrayList ={arrayList.Capacity}");//8

            //ArrayList arrayList02 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Count}");
            ////Count=> Actuall Number Of Elements In Arraylist
            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Capacity}");
            //arrayList02.Add(6);
            //Console.WriteLine("After Adding The Six Element");
            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Count}");
            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Capacity}");
            //----------------------------------------------------------------
            //4 int=>4*4 =16 byte [unused Bytes]
            //Frese || Delete || Deallocate Unused Bytes
            //arrayList02.TrimToSize();
            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Count}");//6

            //Console.WriteLine($"Count Of ArrayList ={arrayList02.Capacity}");//6
            //create A New Array At Heap With Size = Count Of Elements
            //Take Old Element + New Elements In New Array
            //Old Array Now Is Unreachable

            //---------------------
            //arrayList02.Add(7);//Casting From Value Type To Rference Type 
            ////Boxing
            //arrayList02.Add(8);
            //arrayList02.Add("Mohammed");
            ////arrayList=>Hetrogenous List
            ////Compiler Can Not Enforce Type Safty At Compilation 

            ////foreach (int Number in arrayList02)
            ////{
            ////    Console.WriteLine(Number);
            ////}

            //int SumResult = SumArrayList(arrayList02);
            //Console.WriteLine($"The Result is {SumResult}");

            #endregion
            #region Generic - Collections[List]
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");
            //Numbers.Add(1);
            ////adding the First Element To The List The Capacity is
            ////Increased To _defaultCapacity //4
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");//1

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");//4
            //Numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");//4

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");//4
            //Numbers.Add(5);
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");
            //Numbers.TrimExcess();
            ////Create New Array Size = Count Of Eelement 
            ////New Arrat Size =5
            ////Old Array Unreacable
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");

            //List<int> Numbers = new List<int>(5) {1,2,3,4,5 };
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");//5

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");//5
            //Numbers.Add(6);
            //Console.WriteLine($"Count Of ArrayList ={Numbers.Count}");

            //Console.WriteLine($"Count Of ArrayList ={Numbers.Capacity}");
            //Numbers[0] = 12345; //using Indexer As Setter

            //Numbers[9] = 1000;//Invalid
            ////Can Not Use Indexer For adding 
            //for (int i=0; i<=Numbers.Count;i++)
            //{
            //    Console.WriteLine(Numbers[i]);//Using indexer As Getter

            //}
            //foreach (int Number in Numbers)
            //{
            //    Console.WriteLine(Number);

            //}


            //////
            //List<int> Numbers = new List<int>(5) {1,2,3,4,5 };
            ////  Numbers.Add("Rana");
            //Console.WriteLine(Helper.SumList(Numbers));


            #endregion
            #region List Methods
            List<int> Numbers02 = new List<int>() { 1, 2, 3, 1 };
            //Numbers02.Add(1);//Add One Element
            //Numbers02.AddRange(new int[] { 2,3});//Add Range Of Element
            //Numbers02.Insert(3,4);//Insert Element Specific Index In List
            //Numbers02.InsertRange(4,new int[] {5,6});
            // Numbers02.Clear();//Remove All Element In List 
            //Console.WriteLine(Numbers02.BinarySearch(2));//Print  Number of Potitation 
            //Console.WriteLine(Numbers02.Contains(9));//return bool t if the number is exist
            Console.WriteLine(Numbers02.Capacity);
            Console.WriteLine(Numbers02.EnsureCapacity(8));//Increase Capatcity But Chech Ild Capatciy First
            Console.WriteLine(Numbers02.IndexOf(1));
            Console.WriteLine(Numbers02.LastIndexOf(1));
            //foreach (int Number in Numbers02)
            //{
            //    Console.WriteLine(Number);
            //}
            #endregion
        }
    }
}
