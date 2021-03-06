using Mail.Data.Models;
using Mail.Search.Models;
using MailSystem.Implementation;
using MailSystem.Interfaces;
using MailSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MailSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly ISearchManager _searchManager;
        private readonly IActionManager _actionManager;
        private readonly IOrganizeManager _organizeManager;

        public MailController()
        {
            _searchManager = new SearchManager();
            _actionManager = new ActionManager();
            _organizeManager = new OrganizeManager();
        }

        #region Search
        [HttpPost]
        [Route("search")]
        public IActionResult Search(SearchRequest request)
        {
            return Ok(_searchManager.GenerateProcessor(request).Search(request));
        }
        #endregion

        #region Actions
        [HttpGet]
        [Route("receive")]
        public IActionResult Receive()
        {
            return Ok(_actionManager.Receive());
        }

        [HttpPost]
        [Route("send")]
        public IActionResult Send(List<Mail.Data.Models.Mail> request)
        {
            _actionManager.Send(request);
            return Ok();
        }
        #endregion

        #region Custom Directory
        [HttpPost]
        [Route("custom/create")]
        public IActionResult CreateCustomDirectory(CustomDirectory request)
        {
            _organizeManager.CreateCustomDirectory(request);
            return Ok();
        }

        [HttpPost]
        [Route("custom/get")]
        public IActionResult GetCustomDirectory(string request)
        {
            return Ok(_organizeManager.GetCustomDirectory(request));
        }

        [HttpPost]
        [Route("custom/edit")]
        public IActionResult EditCustomDirectory(CustomDirectory request)
        {
            _organizeManager.UpdateCustomDirectory(request);
            return Ok();
        }

        [HttpPost]
        [Route("custom/delete")]
        public IActionResult DeleteCustomDirectory(CustomDirectory request)
        {
            _organizeManager.DeleteCustomDirectory(request);
            return Ok();
        }

        [HttpPost]
        [Route("custom/move")]
        public IActionResult MoveDirectory(MoveDirectory request)
        {
            _organizeManager.MoveDirectory(request.origin, request.destiny);
            return Ok();
        }

        [HttpPost]
        [Route("moveMail")]
        public IActionResult MoveMailDirectory(MoveMailRequest request)
        {
            _organizeManager.MoveMailDirectory(request.mail, request.origin, request.destiny);
            return Ok();
        }
        #endregion
    }
}
