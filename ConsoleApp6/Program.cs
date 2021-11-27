using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AmirRemove
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> superhero = new LinkedList<string>();
            LinkedListNode<string> spiderMan = superhero.AddFirst("Tom Holland");

            superhero.AddLast("Drake Bell");
            superhero.AddAfter(spiderMan, "Jake Johnson");
            superhero.AddBefore(spiderMan, "Garfield");
            superhero.AddLast("Tobey Maguire");

            Console.WriteLine("The linked List Before Deletion: \n ");

            foreach (var item in superhero)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            superhero.RemoveFirst();
            superhero.Remove("Jake Johnson");
            superhero.RemoveLast();

            Console.WriteLine("The linked List After Deletion: \n ");
            foreach (var item in superhero)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.ReadKey();
        }

    }
}