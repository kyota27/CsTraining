using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training1
{
    public enum Operators
    {
        Plus, Minus, Multiply, Divide, None
    }

    public class OperatorHelper
    {
        public static Array GetAllOperators()
        {
            return Enum.GetValues(typeof(Operators));
        }

        public static int Calcuration(Operators o, int left, int right)
        {
            switch (o)
            {
                case Operators.Plus:
                    return left + right;
                case Operators.Minus:
                    return left - right;
                case Operators.Multiply:
                    return left * right;
                case Operators.Divide:
                    return left / right;
                default:
                    return 0;
            }
        }

        public static Operators SignToOperators(object sign)
        {
            if (sign == null)
                return Operators.None;

            switch (sign.ToString())
            {
                case "＋":
                    return Operators.Plus;
                case "－":
                    return Operators.Minus;
                case "×":
                    return Operators.Multiply;
                case "÷":
                    return Operators.Divide;
                default:
                    return Operators.None;
            }
        }
    }

    public static class OperatorExtension
    {
        public static string ToSign(this Operators o)
        {
            switch (o)
            {
                case Operators.Plus:
                    return "＋";
                case Operators.Minus:
                    return "－";
                case Operators.Multiply:
                    return "×";
                case Operators.Divide:
                    return "÷";
                default:
                    return string.Empty;
            }
        }
    }
}
