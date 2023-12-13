using AspNetDropdownList.Models.DomainModels;

namespace AspNetDropdownList.Helper
{
    public class Countries
    {
        public static List<Country> GetAll()
        {
            return new List<Country>
            {
                new Country() {Id = "AU", Name = "Australia"},
                new Country() {Id = "BR", Name = "Brazil"},
                new Country() {Id = "CA", Name = "Canada"},
                new Country() {Id = "FR", Name = "France"},
                new Country() {Id = "DE", Name = "Germany"},
                new Country() {Id = "JP", Name = "Japan"},
                new Country() {Id = "MX", Name = "Mexico"},
                new Country() {Id = "RU", Name = "Russia"},
                new Country() {Id = "TR", Name = "Turkey"},
                new Country() {Id = "US", Name = "United States"},
            };
        }
    }
}
