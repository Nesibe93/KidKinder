using System.Collections.Generic;

namespace KidKinder.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public List<Teacher> Teachers { get; set; } // Bire çok ilişki

    }
}