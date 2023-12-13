using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetDropdownList.Models.ViewModels
{
    public class HomeViewModel
    {
        public string SelectedCountry { get; set; }

        public List<SelectListItem> CountriesSelectist { get; set; }
        
    }
}
