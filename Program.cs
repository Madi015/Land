﻿using System.Xml;

namespace Land
{
    internal class Program
    {
        public class Land
        {
            public string namn, styrestyp, huvudstad, invånarantal;
        }


        static void Main(string[] args)
        {
            Land Sverige = new Land()
            { namn = "Sverige", styrestyp = "Monrki", huvudstad = "Stockholm", invånarantal = "10512820" };
            Land Tyskland = new Land()
            { namn = "Tyskland", styrestyp = "Republik", huvudstad = "Berlin", invånarantal = "83783902 " };
            Land SanMarino = new Land()
            { namn = " San Marino", styrestyp = " Republik", huvudstad = "San Marino", invånarantal = "33600" };

        }
    }
}