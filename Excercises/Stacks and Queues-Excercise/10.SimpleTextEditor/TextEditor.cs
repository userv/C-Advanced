using System;
using System.Collections.Generic;
using System.Text;


namespace _10.SimpleTextEditor
{
    public class TextEditor
    {
        public static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Editor editor = new Editor();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string commanad = tokens[0];
                switch (commanad)
                {
                    case "1":
                        string argument = tokens[1];
                        editor.AppendText(argument);
                        break;
                    case "2":
                        int count = int.Parse(tokens[1]);
                        editor.EraseLastElements(count);
                        break;
                    case "3":
                        int index = int.Parse(tokens[1]) - 1;
                        Console.WriteLine(editor.ElementAtPosition(index));
                        break;
                    case "4":
                        editor.Undo();
                        break;
                }

            }
        }

        public class Editor
        {
            private StringBuilder TextBuffer = new StringBuilder();
            private Stack<Operation> Operations = new Stack<Operation>();

            public void AppendText(string text)
            {
                TextBuffer.Append(text);
                Operations.Push(new Operation { Argument = text, Command = "1" });
            }

            public void EraseLastElements(int count)
            {
                if (count > TextBuffer.Length)
                {
                    TextBuffer.Clear();
                    return;
                }
                int startIndex = TextBuffer.Length - count;
                char[] text = new char[count];
                TextBuffer.CopyTo(startIndex, text, 0, count);
                TextBuffer.Remove(startIndex, count);
                Operations.Push(new Operation { Argument = new string(text), Command = "2" });
            }

            public string ElementAtPosition(int position)
            {
                if (position < 0 || position > TextBuffer.Length - 1)
                {
                    return String.Empty;
                }
                return TextBuffer[position].ToString();
            }

            public void Undo()
            {
                if (Operations.Count == 0)
                {
                    return;
                }
                Operation op = Operations.Pop();
                if (op.Command == "1")
                {
                    int count = op.Argument.Length;
                    EraseLastElements(count);
                }
                else
                {
                    string text = op.Argument;
                    AppendText(text);
                }
                Operations.Pop();
            }
        }
        public class Operation
        {
            public string Command { get; set; }
            public string Argument { get; set; }
        }
    }
}
