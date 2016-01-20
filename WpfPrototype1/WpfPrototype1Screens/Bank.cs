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

        public string EsmCount
        {
            get { return esmCount.ToString() ; }
            set { esmCount = int.Parse(value.Substring(0, value.Length - 1)); }
        }

        public string EgpCount
        {
            get { return egpCount.ToString() ; }
            set { egpCount = int.Parse(value.Substring(0, value.Length - 1)); }
        }

        public string EsmPrice
        {
            get { return esmPrice.ToString() + '$'; }
            set { esmPrice = int.Parse(value.Substring(0, value.Length - 1)); }
        }

        public string EgpPrice
        {
            get { return egpPrice.ToString() + '$'; }
            set { egpPrice = int.Parse(value.Substring(0, value.Length - 1)); }
        }
        private Bank()
        {
            SocketClient socket = new SocketClient();
            Message state=  socket.GetBankState();
            egpCount = int.Parse(state.GetProperty("egpCount").Substring(1, state.GetProperty("egpCount").Length-2));
            egpPrice = int.Parse(state.GetProperty("egpPrice").Substring(1, state.GetProperty("egpPrice").Length - 2));
            esmCount = int.Parse(state.GetProperty("esmCount").Substring(1, state.GetProperty("esmCount").Length - 2));
            esmPrice = int.Parse(state.GetProperty("esmPrice").Substring(1, state.GetProperty("esmPrice").Length - 2));
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
