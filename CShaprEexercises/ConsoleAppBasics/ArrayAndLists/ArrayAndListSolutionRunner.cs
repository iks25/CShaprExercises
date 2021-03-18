﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    public class ArrayAndListSolutionRunner : ISolutionRunner
    {
        public void runSolution(int excerciseNr)
        {
            IConsoleAplication program;
            switch (excerciseNr)
            {
                case 1:
                    program = new WhoLikeYourPostProgram();
                    break;

                default:
                    Console.WriteLine("that exercise is not implemented");
                    return;

            }
            program.ShowOnConsole();
        }
    }
}