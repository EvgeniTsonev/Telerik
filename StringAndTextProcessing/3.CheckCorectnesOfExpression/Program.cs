//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


using System;
class Program
{
    static void Main()
    {
        string expression = "((a+b)/5-d)";
        //string expression = ")(a+b))";
        int length = expression.Length;
        char[] tempExp = new char[length];
        for (int i = 0; i < length; i++)
        {
            tempExp[i] = expression[i];
        }

        int leftBrackets = 0;
        int rightBrackets = 0;
        for (int i = 0; i < length; i++)
        {
            if (tempExp[i] == '(')
                leftBrackets++;
            if (tempExp[i] == ')')
            {
                //special case is when the expression starts with right bracket
                if (leftBrackets == 0)
                    break;
                rightBrackets++;
            }
        }
        //the condition is if the number of the left and right brackets are equal,
        //the expression is correct
        
        if (leftBrackets == rightBrackets && leftBrackets != 0)
            Console.WriteLine("Correct expression");
        else
            Console.WriteLine("Incorect expression");

    }
}

