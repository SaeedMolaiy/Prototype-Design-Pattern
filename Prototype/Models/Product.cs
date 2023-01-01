
namespace Prototype.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public virtual Group Group { get; set; }

        public Product ShallowCopy()
        {
            return (Product)MemberwiseClone();
        }

        public Product DeepCopy()
        {
            var clone = (Product)MemberwiseClone();

            clone.ProductId = ProductId;
            clone.GroupId = GroupId;
            clone.Name = string.Copy(Name);
            clone.ShortDescription = string.Copy(ShortDescription);
            clone.Description = string.Copy(Description);
            clone.Price = Price;

            clone.Group = new Group
            {
                GroupId = 1,
                GroupName = "TestGroup"
            };

            return clone;
        }
    }
}
