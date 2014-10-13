using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    [Serializable]
    class BSTree : ICloneable
    {
        BSTNode head;

        public BSTree()
        {
            head = null;
        }

        public BSTree(int initial)
        {
            head = new BSTNode(initial);
        }
        
        public void Add(int value)
        {
            AddR(ref head, value);
        }

        private void AddR(ref BSTNode N, int value)
        {
            if (N == null)
            {
                BSTNode newNode = new BSTNode(value);
                N = newNode;
            }
            else if(value < N.Data)
            {
                AddR(ref N.left, value);
            }
            else
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public bool Search(int value)
        {
            if (head == null)
            {
                return false;
            }
            else
                return head.Search(value);
        }

        public override string ToString()
        {
            string s = "";
            return Print(head, ref s);
        }

        public string Print(BSTNode N, ref string s)
        {
            if (N == null)
            {
                N = head;
            }
            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.Data.ToString() + " ";
            }
            else
            {
                s = s + N.Data.ToString() + " ";
            }
            if (N.right != null)
            {
                Print(N.right, ref s);
            }

            return s;
        }
        public BSTree Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (BSTree)formatter.Deserialize(ms);
            }
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}