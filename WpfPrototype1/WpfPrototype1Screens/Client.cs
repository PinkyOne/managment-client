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
            get { return cash - loan / 12 - esm * 300 - egp * 500 - BuyFCount * 5000 - UpFCount * 7000 - BuyAFCount * 10000; }
            set { cash = value; }
        }

        public int BuyFCount { get; set; }

        public int UpFCount { get; set; }

        public int BuyAFCount { get; set; }

        public int Dolg
        {
            get
            {
                dolg = esm * 300 + egp * 500 + BuyESMCount * BuyESMCost;
                return dolg;
            }
            set { dolg = value; }
        }

        private int dolg;
        private int buyESMCount = 1;

        public int BuyESMCount
        {
            get { return buyESMCount; }
            set
            {
                Dolg = 0;
                buyESMCount = value;
            }
        }

        public int BuyESMCost
        {
            get { return buyESMCost; }
            set
            {
                Dolg = 0;
                buyESMCost = value;
            }
        }

        private int buyESMCost = 100;
        public int NewLoan { get; set; }

        public int Loan
        {
            get { return loan / 12; }
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
        {
            cash = 10000;
        }
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
        public int SellEGPCost { get; set; }
        public int SellEGPCount { get; set; }
        public int ProduceESMCost { get; set; }
        public int ProduceESMCount { get; set; }

        public void Refresh(Message message)
        {
        }
    }
}
