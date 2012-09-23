using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30TipsAndTricks.WebForms.Models;

namespace _30TipsAndTricks.WebForms.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
    }
}
