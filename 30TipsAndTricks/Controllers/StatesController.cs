using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _30TipsAndTricks.Interfaces;
using _30TipsAndTricks.Repositories;

namespace _30TipsAndTricks.Controllers
{
    public class StatesController : Controller
    {
        private IStateRepository _stateRepository;
        public StatesController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        //
        // GET: /DI/
        public ActionResult Index()
        {
            return View(_stateRepository.GetAll());
        }

    }
}
