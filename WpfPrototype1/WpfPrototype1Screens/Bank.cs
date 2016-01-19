using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfPrototype1Screens
{
    class Bank
    {
        private static object syncRoot = new object();
        private static volatile Bank instance;
        private int esmCount, egpCount, esmPrice, egpPrice;
        List<KeyValuePair<string, int>> users;

        public int EsmCount
        {
            get { return esmCount; }
            set { esmCount = value; }
        }

        public int EgpCount
        {
            get { return egpCount; }
            set { egpCount = value; }
        }

        public int EsmPrice
        {
            get { return esmPrice; }
            set { esmPrice = value; }
        }

        public int EgpPrice
        {
            get { return egpPrice; }
            set { egpPrice = value; }
        }
        private Bank()
        {
            egpCount = 0;
            egpPrice = 0;
            esmCount = 0;
            esmPrice = 0;
        }

        public static Bank Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Bank();
                    }
                }

                return instance;
            }
        }
    }
}
