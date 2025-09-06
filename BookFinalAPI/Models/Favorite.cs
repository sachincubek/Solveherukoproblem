﻿namespace BookFinalAPI.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
