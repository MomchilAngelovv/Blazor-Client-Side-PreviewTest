using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Services
{
    public interface IGlobalState
    {
        int GlobalCounter { get; set; }

        string AppName { get; set; }

        List<string> GlobalChatMessages { get; set; }
    }
}
