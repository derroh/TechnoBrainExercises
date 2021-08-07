using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataManagement
{
    public class DataManager
    {
        static NorthwindEntities db = new NorthwindEntities();
        /// <summary>
        /// Returns list of Product and Category names
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ProductCategory> GetList()
        {
            var Categories = db.Categories.ToList();
            var Products = db.Products.ToList();

            var list = from cat in Categories
                       join prod in Products on cat.CategoryID equals prod.CategoryID
                       select new ProductCategory { CategoryName = cat.CategoryName, ProductName = prod.ProductName };

            return list;

        }
        public static string GetJSON()
        {
            var list = GetList();

            string json = JsonConvert.SerializeObject(list);

            return json;
        }
        public static string GetXML()
        {
            var list = GetList();

            XDocument ProductCategories = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("ProductCategories", from items in list
                                      select new XElement("ProductCategory", 
                                      new XElement("ProductName", items.ProductName),
                                      new XElement("CategoryName", items.CategoryName))

                ));

            return ProductCategories.ToString();
        }

        public static IEnumerable<Customer> GetCustomerList(string cityName)
        {
            var customerList = db.Customers.Where(x => x.City == cityName);

            return customerList;
        }
        public static string GetDistinctCityList()
        {
            var cityList = db.Customers.Select(x => x.City).Distinct().ToList();

            string joined = string.Join(", ", cityList);

            return joined;
        }
        
    }
}
