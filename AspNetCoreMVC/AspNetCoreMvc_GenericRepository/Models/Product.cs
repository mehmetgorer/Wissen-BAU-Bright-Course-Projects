namespace AspNetCoreMvc_GenericRepository.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }     //Foreign Key
        public virtual Category Category { get; set; }      //Navigation Property - Relations
    }
}
