namespace AdventOfCode2020.Models
{
    public class PasswordPolicy
    {
        public int MinimalAmount { get; set; }

        public int MaximumAmount { get; set; }

        public string Character { get; set; }

        public string Password { get; set; }
    }
}
