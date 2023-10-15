namespace GoodHabits
{
    public class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }

        public DateOnly StartDate { get; set; }
        
        //Constructor
        public Habit(string name, int frequency, DateOnly startDate)
        {
            Name = name;
            Frequency = frequency;
            StartDate = startDate;
        }

        public Habit()
        {
            
        }

        public override string ToString()
        {
            return $"{Name} - Should be done every {Frequency}. day";
        }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name can not be null");
            }
            if (Name.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters long");
            }
        }

        public void ValidateFrequency()
        {
            if (Frequency < 2)
            {
                throw new ArgumentOutOfRangeException("Frequency must be at least 2");
            }
        }

        public void Validate()
        {
            ValidateName();
            ValidateFrequency();
        }
    }
}