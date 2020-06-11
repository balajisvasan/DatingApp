using System;
using System.Threading.Tasks;

namespace DataApp.API.Models
{
    public class Like
    {
        public int LikeeId { get; set; }
        public int LikerId { get; set; }
        public User Likee { get; set; }
        public User Liker { get; set; }
    }
}