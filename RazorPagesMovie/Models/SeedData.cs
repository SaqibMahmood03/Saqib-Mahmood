using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesCollege.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCollegeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCollegeContext>>()))
            {
                
                if (context.College.Any())
                {
                    return;   // DB has been seeded
                }

                context.College.AddRange(
                    new College
                    {
                        CollegeName = "Khalsa College",
                        Country = "India",
                        EstablishmentDate =  DateTime.Parse("1892-04-10"),
                        NumberOfStudents = 580000
                    },
                    new College
                    {
                        CollegeName = "Sikh national College",
                        Country = "India",
                        EstablishmentDate =  DateTime.Parse("1938-06-02"),
                        NumberOfStudents = 49500
                    },
                    new College
                    {
                        CollegeName = "DAV College",
                        Country = "India",
                        EstablishmentDate =  DateTime.Parse("1916-07-13"),
                        NumberOfStudents = 152000
                    },
                    new College
                    {
                        CollegeName = "Fanshawe College",
                        Country = "Canada",
                        EstablishmentDate =  DateTime.Parse("1967-09-23"),
                        NumberOfStudents = 96000
                    },
                    new College
                    {
                        CollegeName = "ACET College",
                        Country = "India",
                        EstablishmentDate = DateTime.Parse("1990-10-04"),
                        NumberOfStudents = 145000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}