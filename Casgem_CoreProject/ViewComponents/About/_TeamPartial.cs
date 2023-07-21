using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.About
{
    public class _TeamPartial : ViewComponent
    {
        readonly IOurTeamService _teamService;

        public _TeamPartial(IOurTeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamService.TGetList();
            return View(values);
        }
    }
}
