using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Services
{
    public class GlobalState : IGlobalState
    {
        public int GlobalCounter { get; set; }

        public string AppName { get; set; } = "MyFirstBlazorAppStateClassName";

        public List<string> GlobalChatMessages { get; set; } = new List<string>();
    }
}
