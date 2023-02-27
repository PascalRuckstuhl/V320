using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class MyStack
    {
        // TODO:
        // - Konstruktor erstellen, über den man die Stack-Grösse mitgeben kann
        //   Stack-Grösse definiert die Grösse des internen Arrays data

        private int[] values;//  = new int[10];
        private int topIdx = -1;
        public MyStack(int size)
        {
            this.values = new int[size];
        }

        public void Push(int value)
        {
            //push() erhöht zuerst den Index und speichert im Array an der Stelle des Indexes

            if (this.IsFull)
            {
                throw new Exception("Stack is full.");
            }

            this.topIdx++;
            this.values[topIdx] = value;
        }

        public int Pop()
        {
            // pop() liest den Wert an der Stelle des Index aus dem Array und erniedrigt den Index
            if (this.IsEmpty)
            {
                throw new Exception("Stack is empty.");
            }
            var value = this.values[this.topIdx];
            this.topIdx--;
            return value;
        }

        public bool IsEmpty
        {
            get
            {
                return this.topIdx == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return this.topIdx == this.values.Length - 1;
            }
        }
    }
}
