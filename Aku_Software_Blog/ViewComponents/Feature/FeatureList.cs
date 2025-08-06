using Microsoft.AspNetCore.Mvc;

namespace Aku_Software_Blog.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
