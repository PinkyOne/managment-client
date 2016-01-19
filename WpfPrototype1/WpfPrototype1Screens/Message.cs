using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace WpfPrototype1Screens
{
    class Message
    {
        StringBuilder json;
        public Message()
        {
            json = new StringBuilder("{}");

        }
        public void AddProperty(string property, string value) { 
            json.Insert(1, "\"" + property + "\":" + value + ","); 
        }

        public String getAsString() { 
            return json.Remove(json.Length - 2, 1).ToString();
        }
    }
}
