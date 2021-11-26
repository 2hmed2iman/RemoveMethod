using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace RemovedNode
{
    class program
    {
        static void Main(string[] args)
        {
            //Type A

            Console.Write("Enter The Number Of Elements: ");

            var ElementNum = int.Parse(Console.ReadLine());

            LinkedList<string> xXI6O9IXx = new LinkedList<string>();

            Console.WriteLine();

            for (int i = 1; i <= ElementNum; i++)
            {
                Console.Write($"Enter Index {i - 1} : ");

                var LinkedListElements = Console.ReadLine();

                xXI6O9IXx.AddLast(LinkedListElements);

                Console.WriteLine();
            }

            Console.Write("The linked List Before Deletion: \n\n => ");

            foreach (var item in xXI6O9IXx)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");


            Console.Write("What Do You Want To Remove: \n\n 1. Remove First. \n\n 2. Remove Element.  \n\n 3. Remove Last. \n\n => ");

            var RemoveMethod = Console.ReadLine();

            Console.WriteLine();

            if (RemoveMethod == "Remove First" || RemoveMethod == "remove first" || RemoveMethod == "1")
            {
                xXI6O9IXx.RemoveFirst();
            }
            else if (RemoveMethod == "Remove Last" || RemoveMethod == "remove last" || RemoveMethod == "3")
            {
                xXI6O9IXx.RemoveLast();
            }
            else if (RemoveMethod == "Remove Element" || RemoveMethod == "remove element" || RemoveMethod == "2")
            {
                Console.Write("Enter The Element: ");

                var RemoveElement = Console.ReadLine();

                Console.WriteLine();

                if (xXI6O9IXx.Contains(RemoveElement))
                {
                    xXI6O9IXx.Remove(RemoveElement);
                }
                else
                {
                    Console.WriteLine($"This {RemoveElement} Doesn't Exist \n ");
                }
            }
            else
            {
                Console.WriteLine("Nothing");

                Console.WriteLine();
            }

            Console.Write("The linked List After Deletion: \n\n => ");

            foreach (var item in xXI6O9IXx)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");


            //Type B

            //LinkedList<string> xX6O9Xx = new LinkedList<string>();

            ////LinkedListNode<string> xXOOXx = new LinkedListNode<string>("Aiman");
            ////xX6O9Xx.AddFirst(xXOOXx);

            ////LinkedListNode<string> xXOOXx = new LinkedListNode<string>("");
            ////xXOOXx.Value = "Aiman";
            ////xX6O9Xx.AddFirst(xXOOXx);

            ////var xXOOXx = xX6O9Xx.AddFirst("Aiman");

            //LinkedListNode<string> xXOOXx = xX6O9Xx.AddFirst("Aiman");

            //xX6O9Xx.AddLast("Hafez");
            //xX6O9Xx.AddAfter(xXOOXx, "Mohamed");
            //xX6O9Xx.AddBefore(xXOOXx, "Ahmed");
            //xX6O9Xx.AddLast("Mohamed");

            //Console.WriteLine("The linked List Before Deletion: \n ");
            ////Console.WriteLine();

            //foreach (var item in xX6O9Xx)
            //{
            //    //Console.Write("{0} \n", item);
            //    //Console.WriteLine(item);

            //    //Console.Write("{0} \t", item);
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("\n");

            //xX6O9Xx.RemoveFirst();
            //xX6O9Xx.Remove("Mohamed");
            //xX6O9Xx.RemoveLast();

            //Console.WriteLine("The linked List After Deletion: \n ");
            ////Console.WriteLine();

            //foreach (var item in xX6O9Xx)
            //{
            //    //Console.Write("{0} \n", item);
            //    //Console.WriteLine(item);

            //    //Console.Write("{0} \t", item);
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n");

            Console.ReadKey();
        }

    }
}