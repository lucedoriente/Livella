using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public static class TipoRelazione
    {
        private static string _JOIN;
        private static string _LEFTJOIN;
        private static string _RIGHTJOIN;
        private static string _INNERJOIN;

        public static string Join
        {
            get { return "JOIN"; }
        }

        public static string Leftjoin
        {
            get { return "LEFT JOIN"; }
        }

        public static string Rightjoin
        {
            get { return "RIGHT JOIN"; }
        }

        public static string Innerjoin
        {
            get { return "INNER JOIN"; }
        }
    }
}
