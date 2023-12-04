using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post 
                    {
                        Title = "Lover",
                        Body = "Lover is the seventh studio album by the American singer-songwriter Taylor Swift. It was released on August 23, 2019.",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post
                    {
                        Title = "Red (Taylor's Version)",
                        Body = "Red (Taylor's Version) is the second re-recorded album by the American singer-songwriter Taylor Swift. Released via Republic Records on November 12, 2021.",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post
                    {
                        Title = "Midnights",
                        Body = "Midnights is the tenth studio album by the American singer-songwriter Taylor Swift, released on October 21, 2022.",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}