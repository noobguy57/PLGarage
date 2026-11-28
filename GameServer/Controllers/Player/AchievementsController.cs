using GameServer.Implementation.Common;
using GameServer.Implementation.Player;
using GameServer.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameServer.Controllers.Player
{
    public class AchievementsController(Database database) : Controller
    {
        [Authorize]
        [AllowAnonymous]
        [Route("achievements.xml")]
        public IActionResult Get(int page = 1, int per_page = 50)
        {
            var session = Session.GetSession(database, User);
            return Content(Alerts.GetAlerts(database, session, page, per_page), "application/xml;charset=utf-8");
        }

        protected override void Dispose(bool disposing)
        {
            database.Dispose();
            base.Dispose(disposing);
        }
    }
}