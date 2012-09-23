using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _30TipsAndTricks.Repositories;

namespace _30TipsAndTricks.Controllers
{
    public class StatesController : Controller
    {
        private StateRepository _stateRepository;
        public StatesController(StateRepository stateRepository)
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
