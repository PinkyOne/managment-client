using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfPrototype1Screens
{
    public sealed class Client
    {
        private static object syncRoot = new object();
        private static volatile Client instance;
        private int avatar;
        private string name;
        private int cash, loan, aFabricCount, fabricCount, uFabricCount, esm, egp;

        public int Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public int Loan
        {
            get { return loan; }
            set { loan = value; }
        }

        public int AFabricCount
        {
            get { return aFabricCount; }
            set { aFabricCount = value; }
        }

        public int FabricCount
        {
            get { return fabricCount; }
            set { fabricCount = value; }
        }

        public int UFabricCount
        {
            get { return uFabricCount; }
            set { uFabricCount = value; }
        }

        public int Esm
        {
            get { return esm; }
            set { esm = value; }
        }

        public int Egp
        {
            get { return egp; }
            set { egp = value; }
        }

        private Client()
        { }
        public static Client Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Client();
                    }
                }

                return instance;
            }
        }

        public int SessionId { get; set; }
    }
}
