using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Operatori
    {
        Equal,
        NotEqual,
        LessThen,
        GreaterThen,
        LessEqualThen,
        LessGreaterThen,
        Between,
        Like,
        In
    }

    public static class Convert
    {
        public static string Operator(Operatori operatore)
        {
            switch (operatore)
            {
                case Operatori.Equal:
                    return "=";
                    break;
                case Operatori.NotEqual:
                    return "<>";
                    break;
                case Operatori.LessThen:
                    return "<";
                    break;
                case Operatori.GreaterThen:
                    return ">";
                    break;
                case Operatori.LessEqualThen:
                    return "<=";
                    break;
                case Operatori.LessGreaterThen:
                    return ">=";
                    break;
                case Operatori.Between:
                    return "BETWEEN";
                    break;
                case Operatori.Like:
                    return "LIKE";
                    break;
                case Operatori.In:
                    return "IN";
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
