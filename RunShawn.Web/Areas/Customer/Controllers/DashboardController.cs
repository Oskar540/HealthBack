using RunShawn.Web.Extentions.Contoller;
using System.Web.Mvc;

namespace RunShawn.Web.Areas.Customer.Controllers
{
    [AllowAnonymous]
    [Authorize(Roles = "Admin")]
    public partial class DashboardController : BaseController
    {
        #region Index()
        public virtual ActionResult Index()
        {
            return View(MVC.Customer.Dashboard.Views.Dashboard);
        }
        #endregion

        #region Rewards()
        public virtual ActionResult Rewards()
        {
            return View(MVC.Customer.Dashboard.Views.Rewards);
        }
        #endregion

        #region Achievements()
        public virtual ActionResult Achievments()
        {
            return View(MVC.Customer.Dashboard.Views.Achievements);
        }
        #endregion

    }
}