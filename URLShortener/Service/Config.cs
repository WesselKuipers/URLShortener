using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Service
{
    public class Config
    {
        public static int AdjectiveCount => 2;
        public static int NounCount => 1;

        public static int UrlLength => 12;
        public static string Charset => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
}
