using System;
namespace MyBeerApp
{
    public class Beer
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public Beer(String name,  String image,String description)
        {
            this.Name = name;
            this.Image = image;
            this.Description = description;
        }
    }
}
