using Microsoft.AspNetCore.Components;

namespace SplitTemplateAndCodeC_.ViewModel
{
    public class PageWithBaseClassViewModel : ComponentBase
    {
        protected string Title { get; set; } = "Title : Page With Base Class File";
        protected string Description { get; set; } = "Description : Page With Base Class File";
    }
}
