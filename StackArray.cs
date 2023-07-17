namespace DSA
{
    public class StackArray
    {
        private List<int> arrayStack;
        private int top;
        private int index;
        public int Index { get => index; set => index = value; }
        public int Top { get => top; set => top = value; }
        public List<int> ArrayStack { get => arrayStack; set => arrayStack = value; }

        public StackArray()
        {
            Index = -1;
            ArrayStack = new List<int>();
        }
        public void Push(int data)
        {
            if (Index == -1)
            {
                ++Index;

                ArrayStack.Add(data);
            }
            else
            {
                ++Index;
                ArrayStack.Add(data);
            }
        }
        public void PrintStack()
        {
            String? indicator = "";

            if (Index != -1)
            {
                for (int j = Index; j > -1; --j)
                {
                    if (j == Index)
                    {
                        indicator = "<--- Top";
                    }

                    Console.WriteLine($"|{ArrayStack.ElementAt(j),6}| {indicator}");
                    Console.WriteLine("--------");
                    indicator = "";
                }
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
            Console.WriteLine();
        }
        public void Pop()
        {
            if (Index > -1)
            {
                ArrayStack.RemoveAt(Index);
                --Index;
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        public int Size()
        {
            return ArrayStack.Count;
        }
        public string Peek()
        {
            if (Index > -1)
                return ArrayStack.ElementAt(Index).ToString();
            else
                return "[Stack Is Empty]";
        }
        public string IsEmpty()
        {
            if (Index == -1)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
