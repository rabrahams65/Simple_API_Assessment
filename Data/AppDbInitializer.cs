using Simple_API_Assessment.Models;
using System;

namespace Simple_API_Assessment.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();

                context!.Database.EnsureCreated();


                if (!context.Applicant.Any())
                {
                    context.Applicant.Add(new Applicant()
                    {
                        Id = 1,
                        Name = "Rowan",
                        Skills = new List<Skill>()
                        {
                            new Skill
                        {
                            Id = 1,
                            Name = "C#",
                            ApplicantId = 1,
                        },
                        new Skill
                        {
                            Id = 2,
                            Name = "MS SQL",
                            ApplicantId = 1
                        },
                        new Skill
                        {
                            Id = 3,
                            Name = "Angular",
                            ApplicantId= 1
                        }
                        }
                    });
                    context.SaveChanges();
                }

                
            }


        }
    }

}
