namespace Evaluator.Core;

public class ExpressionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return Calulate(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var stack = new Stack<char>(); 
        var postfix = string.Empty;
        var number = string.Empty; 

        foreach (char item in infix)
        {
            if ((item >= '0' && item <= '9') || item == '.')
            {
                number += item;
            }
            else
            {
                if (!string.IsNullOrEmpty(number))
                {
                    postfix += number + " ";
                    number = string.Empty;
                }

                if (IsOperator(item))
                {
                    if (item == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            postfix += stack.Pop() + " ";
                        }
                        if (stack.Count > 0) stack.Pop(); 
                    }
                    else if (item == '(')
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInfix(item))
                        {
                            postfix += stack.Pop() + " ";
                        }
                        stack.Push(item);
                    }
                }
            }
        }

        if (!string.IsNullOrEmpty(number)) postfix += number + " ";

        while (stack.Count > 0)
        {
            postfix += stack.Pop() + " ";
        }
        return postfix;
    }

    private static double Calulate(string postfix)
    {
        var stack = new Stack<double>();
        var buffer = "";

        foreach (char item in postfix)
        {
            if ((item >= '0' && item <= '9') || item == '.')
            {
                buffer += item;
            }
            else if (item == ' ')
            {
                if (buffer != "")
                {
                    stack.Push(ManualToDouble(buffer));
                    buffer = "";
                }
            }
            else if (IsOperator(item))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(ExecuteOperation(op1, item, op2));
            }
        }
        return stack.Pop();
    }

    private static double ManualToDouble(string s)
    {
        double n = 0, d = 1;
        bool p = false;
        foreach (char c in s)
        {
            if (c == '.') { p = true; continue; }
            n = n * 10 + (c - '0');
            if (p) d *= 10;
        }
        return n / d;
    }
    private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 5,
        _ => 0,
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => 0,
    };

    private static double ExecuteOperation(double op1, char item, double op2) => item switch
    {
        '*' => op1 * op2,
        '/' => op1 / op2,
        '^' => Math.Pow(op1, op2),
        '+' => op1 + op2,
        '-' => op1 - op2,
        '%' => op1 % op2, 
        _ => throw new Exception("Operador no soportado."),
    };
}