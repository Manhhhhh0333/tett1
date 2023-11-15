using Microsoft.AspNetCore.Mvc;
using tett1.Models;

namespace tett1.Components
{
        [ViewComponent(Name = "Post")]
    public class PostComponents : ViewComponent
    {
        private readonly DataContext _context;
        public PostComponents(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofPost = (from p in _context.Posts
                              where (p.IsActive == true) && (p.Status == 1)
                              orderby p.PostID descending
                              select p).Take(3).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofPost));

        }
    }
}
