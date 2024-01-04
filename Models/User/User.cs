using System;
using System.Collections.Generic;

namespace THANG_TEST.Models.User
{
    public partial class User
    {
        public short Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal Phone { get; set; }
        public DateTime Birdday { get; set; }
        public decimal Gender { get; set; }
        public string Password { get; set; } = null!;
        public string Avata { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
