using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _30TipsAndTricks.Models;

namespace _30TipsAndTricks.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
    }
}
