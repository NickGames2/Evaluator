using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluator.Core
{
    public class Stack<T>
    {
        private T[] _stack;
        private int _top;

        public Stack(int n)
        {
            N = n;
            _stack = new T[n];
        }

        public Stack() : this(100) { }

        public int N { get; private set; }

        public bool IsEmpty => _top == 0;

        public bool IsFull => _top == N;

        public T GetItemInTop() => _stack[_top];

        public T Peek() => _stack[_top - 1];

        public int Count => _top;
        public void Push(T item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Stack is full.");
            }
            _stack[_top] = item;
            _top++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empaty.");

            }
            var item = _stack[_top - 1];
            _top--;
            return item;
        }
    }
}
