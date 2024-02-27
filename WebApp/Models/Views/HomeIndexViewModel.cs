using WebApp.Models.Sections;

namespace WebApp.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";
    public ShowcaseViewModel Showcase { get; set; } = new ShowcaseViewModel
    {
        Id = "Showcase",
        ShowcaseImage = new() { ImageUrl = "/images/showcase-taskmaster-page.svg", AltText = "Task Management Assistant" },
        Title = "Task Management Assitant You Gonna Love",
        Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
        BrandsText = "Largest companies use our tool to work efficiently",
        Brands =
        [
            new() { ImageUrl = "/images/brands/logoipsum-1.svg", AltText = "Brand Name 1" },
            new() { ImageUrl = "/images/brands/logoipsum-2.svg", AltText = "Brand Name 2" },
            new() { ImageUrl = "/images/brands/logoipsum-3.svg", AltText = "Brand Name 3" },
            new() { ImageUrl = "/images/brands/logoipsum-4.svg", AltText = "Brand Name 4" },
        ],
    };
}
