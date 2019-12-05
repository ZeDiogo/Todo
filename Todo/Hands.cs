using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo
{
    class Hands<T>
    {
        private T left;
        private T right;

        public Hands(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public void swap()
        {
            T aux = this.left;
            this.left = this.right;
            this.right = aux;
        }

        public T getLeft()
        {
            return this.left;
        }

        public T getRight()
        {
            return this.right;
        }

        public T getLast()
        {
            return this.left;
        }

        public T getCurrent()
        {
            return this.right;
        }

        public void setLeft(T left)
        {
            this.left = left;
        }

        public void setRight(T right)
        {
            this.right = right;
        }

        public void setLast(T last)
        {
            this.left = last;
        }

        public void setCurrent(T current)
        {
            this.right = current;
        }

        public void pushIfNotCurrent(T current)
        {
            if (!this.getCurrent().Equals(current))
            {
                this.swap();
                this.right = current;
            }
        }

        public override string ToString()
        {
            return "<" + this.left.ToString() + ", " + this.left.ToString() + ">";
        }
    }
}
