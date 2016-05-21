using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace losol.netcore_ng2.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
