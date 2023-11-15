using Microsoft.AspNetCore.Mvc;
using tett1.Models;

namespace tett1.Areas.Admin.Components
{
    [ViewComponent(Name = "AdminMenu")]
    public class AdminMenuComponents : ViewComponent
    {
        private readonly DataContext _context;
        public AdminMenuComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            var mnList = (from mn in _context.AdminMenus
                          where (mn.IsActive == true)
                          select mn).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", mnList));

        }
    }
}
