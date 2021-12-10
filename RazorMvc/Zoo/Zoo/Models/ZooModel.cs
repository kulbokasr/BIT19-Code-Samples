namespace Zoo.Models
{
    public class ZooModel
    {
        public static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public ZooModel()
        {
            Id = ++IdCounter;
        }
    }
   
}
