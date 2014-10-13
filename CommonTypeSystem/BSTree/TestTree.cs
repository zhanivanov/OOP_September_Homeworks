using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class TestTree
    {
        public static void Main()
        {
            BSTree myTree = new BSTree();

            for (int i = 0; i < 10; i++)
            {
                myTree.Add(i);
            }
            myTree.Add(2312323);
            Console.WriteLine(myTree);
            Console.WriteLine(myTree.Search(2312323));

            BSTree newTree = myTree.Clone();

            newTree.Add(-5);
            Console.WriteLine(myTree);
            Console.WriteLine(newTree);
        }
    }
}
