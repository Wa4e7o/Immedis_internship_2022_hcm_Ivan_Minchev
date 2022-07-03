using ManagmentSystem.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data
{
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
                            PositionId = 1,
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
                            PositionName = "Vendor consultant",
                            DepartmentName = "Sales",
                            Salary = 1000
                        },
                        new Position()
                        {
                          PositionName = "Аccountant",
                          DepartmentName = "Budget and salaries",
                          Salary = 2000
                        },
                        new Position()
                        {
                          PositionName = "Technical support",
                          DepartmentName = "Supports",
                          Salary = 1500
                        },
                        new Producer()
                        {
                            Name = "David Heyman",
                            Biography = "David Heyman was born on July 26, 1961 in London, England. He is a producer and actor, known for Gravity (2013), Marriage Story (2019) and Once Upon a Time... In Hollywood (2019).",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTYwNzE2MDgxM15BMl5BanBnXkFtZTcwMTIwMDY4NQ@@._V1_UY317_CR104,0,214,317_AL_.jpg"
                        },
                        new Producer()
                        {
                            Name = "Neal H. Moritz",
                            Biography = "Neal H. Moritz is an American film and television producer who was born on June 6, 1959. After graduating from college at Westwood, he earned a master's degree in 1985, which led to a startup of his own production company Neal Moritz Productions. He had a production deal with Paramount Pictures.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BODY1MDY0NDk5Nl5BMl5BanBnXkFtZTgwNTg4ODMwNzE@._V1_UX214_CR0,0,214,317_AL_.jpg"
                        }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
