using System;

namespace BashSoft
{
    public static class InputReader
    {
        private const string EndCommand = "quit";
       

        public static void StartReadingCommands()
        {
            var input = string.Empty;
            while (input != EndCommand)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                input = Console.ReadLine();
                input=input.Trim();
               CommandInterpreter.InterpredCommand(input);
            }
        }

        
    }
}