﻿#undef DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree : IEnumerator, IEnumerable
    
    {
        public class Element
        {
            public int Data;
            public Element pLeft;
            public Element pRight;
            public Element(int Data, Element pLeft = null, Element pRight = null)
            {
                this.Data = Data;
                this.pLeft = pLeft;
                this.pRight = pRight;
#if DEBUG
				Console.WriteLine($"EConstructor:\t{GetHashCode()}"); 
#endif
            }
            ~Element()
            {
#if DEBUG
				Console.WriteLine($"EDestructor:\t{GetHashCode()}"); 
#endif
            }
        }
        public Element Root;
        public Tree()
        {
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Tree()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public void Add(int Data)
        {
            Insert(Data, Root);
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        
        public object Current
        {
            get => Root.Data;
        }
        public bool MoveNext()
        {
            return true;
        }
        public void Reset()
        {

        }
        
        public void Insert(int Data)
        {
            Insert(Data, Root);
        }
        void Insert(int Data, Element Root)
        {
            if (this.Root == null) this.Root = new Element(Data);
            if (Root == null) return;
            if (Data < Root.Data)
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Data);
                else Insert(Data, Root.pLeft);
            }
            else
            {
                if (Root.pRight == null) Root.pRight = new Element(Data);
                else Insert(Data, Root.pRight);
            }
        }
        public int Min()
        {
            if (Root == null) throw new Exception("No Tree in Min");
            return Min(Root);
        }
        int Min(Element Root)
        {
            return Root.pLeft == null ? Root.Data : Min(Root.pLeft);
            //if (Root.pLeft == null) return Root.Data;
            //else return Min(Root.pLeft);
        }
        public int Max()
        {
            if (Root == null) throw new Exception("No Tree in Max");
            return Max(Root);
        }
        int Max(Element Root)
        {
            return Root.pRight == null ? Root.Data : Max(Root.pRight);
        }
        public int Count()
        {
            return Count(Root);
        }
        int Count(Element Root)
        {
            return Root == null ? 0 : Count(Root.pLeft) + Count(Root.pRight) + 1;
        }
        public int Sum()
        {
            return Sum(Root);
        }
        int Sum(Element Root)
        {
            return Root == null ? 0 : Sum(Root.pLeft) + Sum(Root.pRight) + Root.Data;
        }
        public double Avg()
        {
            return (double)Sum(Root) / Count(Root);
        }
        public int Depth()
        {
            return Depth(Root);
        }
        public int Depth(Element Root)
        {
            if (Root == null) return 0;
            //else return
            //		Depth(Root.pLeft) + 1 > Depth(Root.pRight) + 1 ?
            //		Depth(Root.pLeft) + 1 :
            //		Depth(Root.pRight) + 1;
            int lDepth = Depth(Root.pLeft) + 1;
            int rDepth = Depth(Root.pRight) + 1;
            return Math.Max(lDepth, rDepth);
        }

        public void Print()
        {
            Print(Root);
            Console.WriteLine();
        }
        void Print(Element Root)
        {
            if (Root == null) return;
            Print(Root.pLeft);
            Console.Write($"{Root.Data}\t");
            Print(Root.pRight);
        }
    }
}