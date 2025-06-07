using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Pattern.Models
{
    public class Product : IPrototype
    {
        private string _name;
        private double _price;
        private string _description;
        private double _rating;
        private string _category;
        public Product(string name, double price, string description, double rating, string category) 
        {
            this._name = name;
            this._price = price;
            this._description = description;
            this._rating = rating;
            this._price = price;
            this._category = category;
        }
        public IPrototype Clone() => new Product(_name, _price, _description, _rating, _category);

    }
}
