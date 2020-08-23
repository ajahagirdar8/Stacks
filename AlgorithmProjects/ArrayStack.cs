﻿using System;
namespace Algorithms
{
    public class ArrayStack<T>
    {
        private T[] astack;
        private int N;

        public ArrayStack(int size)
        {
            astack = new T[size];
        }

        public Boolean isEmpty()
        {
            return N == 0;
        }

        public void push(T item)
        {
            astack[N++] = item;
        }

        public T pop()
        {
            return astack[--N];
        }
    }
}
