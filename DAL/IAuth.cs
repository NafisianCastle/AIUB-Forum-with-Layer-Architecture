using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAuth<out TX>
    {
        TX Authenticate(string email, string password);
    }
}