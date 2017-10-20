using Microsoft.AspNetCore.Mvc;
using Santa.Models;

namespace Santa.Controllers
{
    public class PartyController : Controller
    {
        private IPartyRepository repository;

        public PartyController(IPartyRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.parties);
    }
}