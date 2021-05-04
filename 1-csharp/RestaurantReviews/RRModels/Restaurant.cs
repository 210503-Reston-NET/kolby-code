using System.Collections.Generic;

/// <summary>
/// Namespace for models
/// </summary>
namespace RRModels
{
    /// <summary>
    /// Data structure used to define a restaurant
    /// </summary>
    public class Restaurant
    {
        // Class members
        // 1. Constructor
        // 2. Fields
        // 3. Methods
        // 4. Properties (getter and setter)

        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public Restaurant()
        {

        }

        /// <summary>
        /// Describes name of restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Describes location 
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// Describes location
        /// </summary>
        /// <value></value>
        public string State { get; set; }

        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State} \n Review: {Reviews}";
        }
    }
}