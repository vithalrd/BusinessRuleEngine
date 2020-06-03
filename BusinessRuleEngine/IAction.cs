using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Action interface for all actions to be execute after payment
    /// </summary>
    public interface IAction
    {
        string DoProcess();
    }
}
