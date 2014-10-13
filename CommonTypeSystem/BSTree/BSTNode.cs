using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    [Serializable]
    class BSTNode
    {
        private int data;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int data)
        {
            this.Data = data;
            this.left = null;
            this.right = null;
        }

        public int Data 
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public bool Search(int value)
        {
            if (value == this.data)
                return true;
            else if (value < this.data)
            {
                if (left == null)
                    return false;
                else
                    return left.Search(value);
            }
            else if (value > this.data)
            {
                if (right == null)
                    return false;
                else
                    return right.Search(value);
            }
            return false;
        }
    }
}
