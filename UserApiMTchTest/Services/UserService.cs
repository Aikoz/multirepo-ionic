using UserApiMTchTest.Models;
using System.Collections.Generic;

namespace UserApiMTchTest.Services
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Jose Luis Florencio Ortiz", Email = "aikoz_1@live.com" },
                new User { Id = 2, Name = "Bob Smith", Email = "bob.smith@hotmail.com" },
                new User { Id = 3, Name = "Charlie Brown", Email = "charlie.brown@gmail.com" },
                new User { Id = 4, Name = "Diana Prince", Email = "diana.prince@hotmail.com" },
                new User { Id = 5, Name = "Edward Norton", Email = "edward.norton@gmail.com" },
                new User { Id = 6, Name = "Fiona Gallagher", Email = "fiona.gallagher@hotmail.com" },
                new User { Id = 7, Name = "George Martin", Email = "george.martin@gmail.com" },
                new User { Id = 8, Name = "Hannah Lee", Email = "hannah.lee@hotmail.com" },
                new User { Id = 9, Name = "Isaac Newton", Email = "isaac.newton@gmail.com" },
                new User { Id = 10, Name = "Jessica Alba", Email = "jessica.alba@hotmail.com" },
                new User { Id = 11, Name = "Kevin Hart", Email = "kevin.hart@gmail.com" },
                new User { Id = 12, Name = "Laura Croft", Email = "laura.croft@hotmail.com" },
                new User { Id = 13, Name = "Matthew Perry", Email = "matthew.perry@gmail.com" },
                new User { Id = 14, Name = "Nina Simone", Email = "nina.simone@hotmail.com" },
                new User { Id = 15, Name = "Oscar Isaac", Email = "oscar.isaac@gmail.com" },
                new User { Id = 16, Name = "Paula Abdul", Email = "paula.abdul@hotmail.com" },
                new User { Id = 17, Name = "Quincy Jones", Email = "quincy.jones@gmail.com" },
                new User { Id = 18, Name = "Rachel Green", Email = "rachel.green@hotmail.com" },
                new User { Id = 19, Name = "Sam Wilson", Email = "sam.wilson@gmail.com" },
                new User { Id = 20, Name = "Tina Turner", Email = "tina.turner@hotmail.com" },
                new User { Id = 21, Name = "Ulysses Grant", Email = "ulysses.grant@gmail.com" },
                new User { Id = 22, Name = "Victoria Beckham", Email = "victoria.beckham@hotmail.com" },
                new User { Id = 23, Name = "Will Smith", Email = "will.smith@gmail.com" },
                new User { Id = 24, Name = "Xena Warrior", Email = "xena.warrior@hotmail.com" },
                new User { Id = 25, Name = "Yara Shahidi", Email = "yara.shahidi@gmail.com" }
            };
        }
    }
}