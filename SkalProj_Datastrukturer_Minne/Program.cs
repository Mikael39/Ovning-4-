using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Recursive Check"
                    + "\n6. Iterative Check"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        Recursive();
                        break;
                    case '6':
                        Iterative();
                        break;
                  
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5 or 6)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary> Initiates List and describes current List capacity and list number of instances in list. gives user option for adding or removing
        /// element from list, updates list. if user inputs invalid argument the default asks the user to input correct format. User is asked for input untill user
        /// exits loop by pressing 0 exiting to main menu. For each loop capacity and count is displayed to user.
        static void ExamineList()
        {
            List<string> theList = new List<string>();
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Current List Capacity: {theList.Capacity}");
                Console.WriteLine($"Current List Size: {theList.Count}");
                Console.Write("Add or subtract from list by entering + or - (do not enter space after the + or -)"
                    + "\n   +Input"
                    + "\n   -Input"
                    + "\n    3 Display Listmembers"
                    + "\n    0 Exits to main menu"
                    + "\n\n Enter Input: ");
        
                try
                {
                    string input = Console.ReadLine();
                    int nav = input[0];
                    string value = input.Substring(1);

                    switch (nav)
                    {
                        case '+':
                            if (String.IsNullOrEmpty(value))
                                Console.WriteLine("Please enter a value to be added after +");

                            else
                                theList.Add(value);
                            Console.WriteLine("List updated");
                            Console.ReadLine();
                            break;
                        case '-':
                            if (theList.Contains(value))
                            {
                                theList.Remove(value);
                                Console.WriteLine("Listmember Removed");
                            }
                            else
                            {
                                Console.WriteLine("Non Valid Listmember");
                            }
                            Console.ReadLine();
                            break;
                        case '3':
                            foreach (var ele in theList)
                            { Console.WriteLine(ele); }
                            Console.ReadLine();
                            break;
                        case '0':
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please enter valid input (+ or -, followed by input)");
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }

            }

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// creates a queue, displays current que size.  gives option to add or subtract for Que as well as displaying current queue. checks if 
        /// there is value to be added.
        static void ExamineQueue()
        {

            Queue<string> theQueue = new Queue<string>();
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Current Queue Size: {theQueue.Count} ");
                Console.Write("Add or subtract from Queue by entering + or - (Add Person entering the Queue after +)"
                    + "\n+   Input "
                    + "\n-   (No need to enter anything after -  "
                    + "\n3   Display Current Queue"
                    + "\n0   Exits to main menu"
                    + "\n\n Enter Input: ");

                try
                {
                    string input = Console.ReadLine();
                    char nav = input[0];
                    string value = input.Substring(1);


                    switch (nav)
                    {
                        case '+':

                            if (String.IsNullOrEmpty(value))
                            {
                                throw new IndexOutOfRangeException();
                              
                            }
                            else
                            {
                                theQueue.Enqueue(value);
                                Console.WriteLine("Queue Updated");
                            }
                            Console.ReadLine();
                            break;
                        case '-':
                            theQueue.Dequeue();
                            Console.WriteLine("Queue Updated");
                            Console.ReadLine();
                            break;
                        case '3':
                            foreach (var ele in theQueue)
                            { Console.WriteLine(ele); }
                            Console.ReadLine();
                            break;
                        case '0':
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please enter valid input (+ or -, followed by input)");
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }
            }
           
        }
        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            Stack<char> theStack = new Stack<char>();
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Current Stack Size: {theStack.Count} ");
                Console.Write("1) Enter a word or a sentence that you would like to be reversed: "                   
                    + "\n0) Exits to main menu"
                    + "\n\n Enter Input: ");
                try
                {
                    string input = Console.ReadLine();
                    char nav = input[0];

                    switch (nav)
                    {
                        case '1':
                            ReverseString(theStack);
                            break;
                        case '0':
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please enter either a word/sentance or Exit to main menu)");
                            break;
                    }

                }

                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }

                static void ReverseString(Stack<char> theStack)
                {
                    Console.Write("Enter the word or Sentence: ");
                    int i;
                    string input = Console.ReadLine();
                    char[] ch = new Char[input.Length];
                    for (i = 0; i < input.Length; i++)
                    {
                        ch[i] = input[i];
                        theStack.Push(ch[i]);
                    }

                    for (i = 0; i < input.Length; i++)
                    {                         
                       ch[i] = theStack.Pop();
                       
                    }
                    string output = new string(ch);
                    Console.WriteLine($"Reversed string: {output}");
                    Console.ReadLine();
                }             
            }
        }

        static void CheckParanthesis()
        {
            
            while (true)
            {


                Stack<char> stack = new Stack<char>();
                Console.Clear();

                Console.WriteLine($"Parenthesis Checker ");
                Console.Write(" 1 = Testing string that needs to be verified "
                    + "\n 0 = Exits to main menu"
                    + "\n\n Enter Input: ");

                try
                {

                    string input = Console.ReadLine();
                    char nav = input[0];



                    switch (nav)
                    {
                        case '1':
                            Console.Clear();
                            ParenthesisChecker(stack);
                            break;


                        case '0':
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please enter either a word/sentance or Exit to main menu)");
                            break;
                    }

                }

                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }

                static void ParenthesisChecker(Stack<char> stack)
                {
                    Console.Write("Enter the word or Sentence: ");
                    string check = Console.ReadLine();
                    int i;
                    try
                    {
                        if (String.IsNullOrEmpty(check))
                        {
                            throw new IndexOutOfRangeException("Input something");
                        }
                        for (i = 0; i < check.Length; i++)
                        {
                            char c = check[i];
                            if (c == '(' || c == '{' || c == '[')
                            { stack.Push(c); }

                            else if (c == ')' || c == '}' || c == ']')
                            {

                                if (!stack.Any())
                                {
                                    throw new ArgumentException("InCorrect use of parentheses");
                                }
                                char t = stack.Pop();

                                switch (c)
                                {
                                    case ')':
                                        if (t != '(')
                                        {
                                            throw new ArgumentException("InCorrect use of parentheses");
                                        }
                                        break;
                                    case ']':
                                        if (t != '[')
                                        {
                                            throw new ArgumentException("InCorrect use of parentheses");
                                        }
                                        break;
                                    case '}':
                                        if (t != '{')
                                        {
                                            throw new ArgumentException("InCorrect use of parentheses");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        if (stack.Any())
                        {
                            throw new ArgumentException("InCorrect use of parentheses");
                        }

                        if (i == check.Length)

                            Console.WriteLine("Correct use of parentheses");
                    }

                    catch (IndexOutOfRangeException ex)
                    {
                        
                        Console.WriteLine(ex.Message);
                        
                    }

                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }                                           
                    Console.ReadLine();                      
                }
            }
        }
        static void Recursive()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Recursive Checker ");
                Console.Write(" 1 = Tests Odd Recursive number"
                    + "\n 2 = Tests Even Recursive number"
                    + "\n 3 = Tests recursive fibonaci Sequence"
                    + "\n 0 = Exits to main menu"
                    + "\n\n Enter Input: ");

                try
                {

                    string input = Console.ReadLine();
                    char nav = input[0];
                    switch (nav)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine("Enter a odd number to be tested");
                            int n = int.Parse(Console.ReadLine());
                            if (n % 2 == 0)
                            {
                                throw new ArgumentException("input an odd number");
                            }
                            Console.WriteLine($" Result of test: {RecursiveOdd(n)} ");
                            Console.ReadLine();
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine("Enter a even number to be tested");
                            int k = int.Parse(Console.ReadLine());
                            if (k % 2 == 1)
                            {
                                throw new ArgumentException("input an Even number");
                            }
                            Console.WriteLine($" Result of test: {RecursiveEven(k)} ");
                            Console.ReadLine();
                            break;
                        case '3':
                            Console.Clear();
                            Console.WriteLine("Length of Fibonacci Sequence");
                            int f = int.Parse(Console.ReadLine());
                            Console.WriteLine($" Result of test: {RecursiveFibonaci(f)} ");
                            Console.ReadLine();
                            break;
                        case '0':
                            Console.Clear();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Please enter 1 or 2, or 0 to exit to main menu)");
                            break;
                    }

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    Console.ReadLine();
                }

                static int RecursiveOdd(int n)
                {
                    
                    if (n == 1)
                    {
                        return 1;
                    }
                    return (RecursiveOdd(n - 1) + 2);
                }

                static int RecursiveEven(int k)
                
                {
                    if (k == 2)
                    {
                        return 2;
                    }
                    return (RecursiveEven(k - 2) + 2);
                }

                static int RecursiveFibonaci(int f)
                {
                    if (f == 0)
                        return 0;
                    else if (f == 1)
                        return 1;
                    else
                        return RecursiveFibonaci(f - 2) + RecursiveFibonaci(f - 1);
                }
            }
        }


        static void Iterative()
        {

            Console.Clear();
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Iteraive Checker ");
                Console.Write(" 1 = Tests Odd Iterative number"
                    + "\n 2 = Tests Even Iterative number"
                    + "\n 3 = Tests Iterative fibonaci Sequence"
                    + "\n 0 = Exits to main menu"
                    + "\n\n Enter Input: ");

                    try
                    {

                        string input = Console.ReadLine();
                        char nav = input[0];
                        switch (nav)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("Enter a odd number to be tested");
                                int n = int.Parse(Console.ReadLine());
                            if (n % 2 == 0)
                            {
                                throw new ArgumentException("input an odd number");
                            }
                            Console.WriteLine($" Result of test: {IterativeOdd(n)} ");
                                Console.ReadLine();
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine("Enter a even number to be tested");
                                int k = int.Parse(Console.ReadLine());
                                if (k % 2 == 1)
                                {
                                throw new ArgumentException("input an Even number");
                                }
                                Console.WriteLine($" Result of test: {IterativeEven(k)} ");
                                Console.ReadLine();
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("Length of Fibonacci Sequence");
                                int f = int.Parse(Console.ReadLine());
                                Console.WriteLine($" Result of test: {IterativeFibonaci(f)} ");
                                Console.ReadLine();
                                break;
                            case '0':
                                Console.Clear();
                                Main();
                                break;
                            default:
                                Console.WriteLine("Please enter 1 or 2, or 0 to exit to main menu)");
                                break;
                        }

                    }

                    catch (IndexOutOfRangeException)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter some input!");
                        Console.ReadLine();
                    }

                    catch (ArgumentException ex)
                    {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    }




                static int IterativeOdd(int n)
                    {
                       if (n == 1)
                        {
                            return 1;
                        }
                       
                        return (IterativeOdd(n - 1) + 2);
                    }

                    static int IterativeEven(int k)

                    {
                        if (k == 2)
                        {
                            return 2;
                        }
                        return (IterativeEven(k - 2) + 2);
                    }

                    static int IterativeFibonaci(int f)
                    {
                        int a = 0;
                        int b = 1;

                        if (f == 0)
                            return a;

                        for (int i = 1; i < f; i++)
                        {
                            int c = a;
                            a = b;
                            b = c + a;
                        }
                        return b;
                    }                                         
            }
        }

    }
}

