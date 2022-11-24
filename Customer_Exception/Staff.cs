namespace Custom_Exception
{
    internal class Staff
    {
        private string Name { get; set; }
        private string Bio { get; set; }
        public int Age { get; set; }
        public Staff(string name, string bio, int age)
        {
            Name = name;
            Bio = bio;
            Age = age;
        }
    }
}
