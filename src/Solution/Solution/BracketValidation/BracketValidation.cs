using System;

namespace Solution.BracketValidation
{
    public class Node
    {
        public char Data { get; set; }
        public Node Next { get; set; }

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    public class BracketValidator
    {
        private Node top;

        public BracketValidator()
        {
            top = null;
        }

        private void Push(char data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        private char Pop()
        {
            if (top == null)
                return '\0'; // Return null character if stack is empty

            char data = top.Data;
            top = top.Next;
            return data;
        }

        private bool IsEmpty()
        {
            return top == null;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char last = Pop();
                    if (!IsMatchingPair(last, ch))
                        return false;
                }
            }
            return IsEmpty();
        }

        private bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }

}
