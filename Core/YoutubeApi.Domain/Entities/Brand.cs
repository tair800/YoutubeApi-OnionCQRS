namespace YoutubeApi.Domain.Entities
{
    public class Brand
    {
        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
