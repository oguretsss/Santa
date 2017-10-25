using System.Linq;
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
        public ViewResult ListByCreator(string creatorId) => View("List", repository.parties.Where(a => a.CreatorID == creatorId));
        public ViewResult ListByStatus(string partyStatus) => View("List", repository.parties.Where(a => a.PartyStatus == partyStatus));
    }
}