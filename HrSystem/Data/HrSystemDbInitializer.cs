namespace HrSystem.Data
{
    using HrSystem.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HrSystemDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<HrSystemDbContext>();

                context.Database.EnsureCreated();

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Boris ",
                            LastName = "Becker",
                            Age = 32,
                            ImageURL = "https://ichef.bbci.co.uk/news/976/cpsprodpb/77B6/production/_124364603_169-gettyimages-1240321438.jpg",
                            Address = "Malko Tyrnovo, str.Rayna Knyaginya 2",
                            Email = "boris_tennis@gmail.com",
                            MedicalStauts = "Healty",
                            PhoneNumber = "0895667791",
                            PositionId = 1,
                            StartDate = DateTime.Now.AddDays(-10)
                        },
                        new Employee()
                        {
                            FirstName = "Krasi",
                            LastName = "Radkov",
                            Age = 27,
                            ImageURL = "hhttps://nstatic.nova.bg/public/pics/nova/production_people/img_1646059001.jpg",
                            Address = "Plovdiv, str.Vladimir Visotski 9",
                            Email = "slavi_shou@gmail.com",
                            MedicalStauts = "Back pain, can't lift heavy",
                            PhoneNumber = "0897668893",
                            PositionId = 3,
                            StartDate = DateTime.Now.AddDays(-60)
                        },
                        new Employee()
                        {
                            FirstName = "Lili",
                            LastName = "Ivanova",
                            Age = 19,
                            ImageURL = "https://epicenter.bg/images/news/12021/pics/1611560229.jpg",
                            Address = "Dryanovo, str.Bacho Kiro 19",
                            Email = "neustoima_diva@gmail.com",
                            MedicalStauts = "Аrrhythmia",
                            PhoneNumber = "0898773543",
                            PositionId = 2,
                            StartDate = DateTime.Now.AddDays(-20)
                        },
                        new Employee()
                        {
                            FirstName = "Tedy",
                            LastName = "Georgo",
                            Age = 41,
                            ImageURL = "https://img.novini.bg/uploads/news_pictures/2017-51/big/dj-tedi-djordjo-prebiha-me-policai-485488.png",
                            Address = "Sofia, str.Lorenco Lamas 49",
                            Email = "car_lyv@gmail.com",
                            MedicalStauts = "Problem with eyes",
                            PhoneNumber = "0893753263",
                            PositionId = 4,
                            StartDate = DateTime.Now.AddDays(-20)
                        },
                         new Employee()
                        {
                            FirstName = "Ivet",
                            LastName = "Lalova",
                            Age = 37,
                            ImageURL = "https://www.atletikabg.com/wp-content/uploads/223476886_371079854363237_8262917684309448832_n-448x336.jpg",
                            Address = "Varna, str.Morska sreshta 73",
                            Email = "catchmeifucan@gmail.com",
                            MedicalStauts = "No problems",
                            PhoneNumber = "0895716213",
                            PositionId = 5,
                            StartDate = DateTime.Now.AddDays(-20)
                        },
                    });

                    context.SaveChanges();
                }

                if (!context.Positions.Any())
                {
                    context.Positions.AddRange(new List<Position>()
                    {
                        new Position()
                        {
                            PositionName = "Sales representative",
                            DepartmentName = "Sales Department",
                            Salary = 1000
                        },
                        new Position()
                        {
                          PositionName = "Аccountant",
                          DepartmentName = "Budget and salaries Department",
                          Salary = 2500
                        },
                        new Position()
                        {
                          PositionName = "Customer support",
                          DepartmentName = "TaxBack",
                          Salary = 1700
                        },
                         new Position()
                        {
                          PositionName = "Cleaner",
                          DepartmentName = "Upkeeping Department",
                          Salary = 700
                        },
                          new Position()
                        {
                          PositionName = "Manager",
                          DepartmentName = "Technicle Department",
                          Salary = 4500,
                        },
                    });

                    context.SaveChanges();
                }

                if (!context.PreviousExperiences.Any())
                {
                    context.PreviousExperiences.AddRange(new List<PreviousExperience>()
                    {
                        new PreviousExperience()
                        {
                             Employeer = "Metro Cash and Cary",
                             PositionName = "Manager",
                             RecomendationLetter = "Very good employee, knows how to lead the team well. Conscientiously completes assigned tasks on time."
                        },
                        new PreviousExperience()
                        {
                             Employeer = "Coca Cola",
                             PositionName = "Аccountant",
                             RecomendationLetter = "He is very good with accounts and knows how to save the company money."
                        },
                        new PreviousExperience()
                        {
                             Employeer = "Lidl",
                             PositionName = "Vendor consultant",
                        },
                        new PreviousExperience()
                        {
                             Employeer = "Municipality Gabrovo",
                             PositionName = "Cleaner",
                        },
                       new PreviousExperience()
                        {
                             Employeer = "Uber",
                             PositionName = "Customer support",
                             RecomendationLetter = "A very positive and smiling person. Completes assigned tasks on time. Able to maintain confidentiality."
                        },
                    });

                    context.SaveChanges();
                }

                if (!context.EmployeePreviousExperienceConnections.Any())
                {
                    context.EmployeePreviousExperienceConnections.AddRange(new List<EmployeePreviousExperienceConnection>()
                    {
                        new EmployeePreviousExperienceConnection()
                        {
                         EmployeeId = 1,
                         PreviousExperienceId = 3
                        },
                       new EmployeePreviousExperienceConnection()
                        {
                         EmployeeId = 2,
                         PreviousExperienceId = 5
                        },
                       new EmployeePreviousExperienceConnection()
                        {
                         EmployeeId = 3,
                         PreviousExperienceId = 2
                        },
                        new EmployeePreviousExperienceConnection()
                        {
                         EmployeeId = 4,
                         PreviousExperienceId = 4
                        },
                        new EmployeePreviousExperienceConnection()
                        {
                         EmployeeId = 5,
                         PreviousExperienceId = 1
                        },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
