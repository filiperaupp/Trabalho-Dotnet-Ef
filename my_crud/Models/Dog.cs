namespace my_crud.Models
{
    public class Dog
    {
        public Dog(){}
        public Dog(int id, string name, string race, string size)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.size = size;

        }
        public int id { get; set; }
        public string name { get; set; }
        public string race { get; set; }
        public string size { get; set; }


    }
}