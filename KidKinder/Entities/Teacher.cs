﻿namespace KidKinder.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; } // Bire çok ilişki
    }
}