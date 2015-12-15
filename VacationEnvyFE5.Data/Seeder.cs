using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using VacationEnvyFE5.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace VacationEnvyFE5.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            //SEEDER REDO/EDIT 7-18 AC

            // Countries table seeder modified by KI

            context.Countries.AddOrUpdate(
            c => c.CountryId,
            new Country() { CountryName = "Spain" },
            new Country() { CountryName = "Italy" },
            new Country() { CountryName = "Greece" },
            new Country() { CountryName = "Germany" },
            new Country() { CountryName = "France" },
            new Country() { CountryName = "USA" },                  //country id=6
            new Country() { CountryName = "Mexico" },
            new Country() { CountryName = "Fiji" },
            new Country() { CountryName = "Japan" },
            new Country() { CountryName = "Taiwan" },
            new Country() { CountryName = "China" },
            new Country() { CountryName = "India" }        // Total of 12 countries.
            );
            context.SaveChanges();

            // States seeder modified by KI
            context.States.AddOrUpdate(
                s => s.StateId,
                new State() { StateName = "Alabama", CountryId = 6},
                new State() { StateName = "Alaska", CountryId = 6 },
                new State() { StateName = "Arizona", CountryId = 6 },
                new State() { StateName = "Arkansas", CountryId = 6 },
                new State() { StateName = "California", CountryId = 6 },
                new State() { StateName = "Colorado", CountryId = 6 },
                new State() { StateName = "Connecticut", CountryId = 6 },
                new State() { StateName = "Delaware", CountryId = 6 },
                new State() { StateName = "Florida", CountryId = 6 },
                new State() { StateName = "Georgia", CountryId = 6 },
                new State() { StateName = "Hawaii", CountryId = 6 },
                new State() { StateName = "Idaho", CountryId = 6 },
                new State() { StateName = "Illinois", CountryId = 6 },
                new State() { StateName = "Indiana", CountryId = 6 },
                new State() { StateName = "Iowa", CountryId = 6 },
                new State() { StateName = "Kansas", CountryId = 6 },
                new State() { StateName = "Kentucky", CountryId = 6 },
                new State() { StateName = "Lousiana", CountryId = 6 },
                new State() { StateName = "Maine", CountryId = 6 },
                new State() { StateName = "Maryland", CountryId = 6 },
                new State() { StateName = "Massachusetts", CountryId = 6 },
                new State() { StateName = "Michigan", CountryId = 6 },
                new State() { StateName = "Minnesota", CountryId = 6 },
                new State() { StateName = "Mississippi", CountryId = 6 },
                new State() { StateName = "Missouri", CountryId = 6 },
                new State() { StateName = "Montana", CountryId = 6 },
                new State() { StateName = "Nebraska", CountryId = 6 },
                new State() { StateName = "Nevada", CountryId = 6 },
                new State() { StateName = "New Hampshire", CountryId = 6 },
                new State() { StateName = "New Jersey", CountryId = 6 },
                new State() { StateName = "New Mexico", CountryId = 6 },
                new State() { StateName = "New York", CountryId = 6 },
                new State() { StateName = "North Carolina", CountryId = 6 },
                new State() { StateName = "North Dakota", CountryId = 6 },
                new State() { StateName = "Ohio", CountryId = 6 },
                new State() { StateName = "Oklahoma", CountryId = 6 },
                new State() { StateName = "Oregon", CountryId = 6 },
                new State() { StateName = "Pennsylvania", CountryId = 6 },
                new State() { StateName = "Rhode Island", CountryId = 6 },
                new State() { StateName = "South Carolina", CountryId = 6 },
                new State() { StateName = "South Dakota", CountryId = 6 },
                new State() { StateName = "Tennessee", CountryId = 6 },
                new State() { StateName = "Texas", CountryId = 6 },
                new State() { StateName = "Utah", CountryId = 6 },
                new State() { StateName = "Vermont", CountryId = 6 },
                new State() { StateName = "Virginia", CountryId = 6 },
                new State() { StateName = "Washington", CountryId = 6 },
                new State() { StateName = "West Virginia", CountryId = 6 },
                new State() { StateName = "Wisconsin", CountryId = 6 },
                new State() { StateName = "Wyoming", CountryId = 6 }        // 50 US states
                );
            context.SaveChanges();

            // Cities seeder modified by KI
            context.Cities.AddOrUpdate(
                c => c.CityId,
                new City() { CityName = "Madrid", CountryId = 1 },
                new City() { CityName = "Barcelona", CountryId = 1 },
                new City() { CityName = "Cordoba", CountryId = 1 },
                new City() { CityName = "Sevilla", CountryId = 1 },
                new City() { CityName = "Ronda", CountryId = 1 },
                new City() { CityName = "Granada", CountryId = 1 },
                new City() { CityName = "Milan", CountryId = 2 },
                new City() { CityName = "Venicia", CountryId = 2 },
                new City() { CityName = "Florence", CountryId = 2 },
                new City() { CityName = "Pisa", CountryId = 2 },
                new City() { CityName = "Rome", CountryId = 2 },
                new City() { CityName = "Turin",  CountryId = 2 },
                new City() { CityName = "Athens", CountryId = 3 },
                new City() { CityName = "Patras", CountryId = 3 },
                new City() { CityName = "Chania", CountryId = 3 },
                new City() { CityName = "Dephi", CountryId = 3 },
                new City() { CityName = "Argos", CountryId = 3 },
                new City() { CityName = "Olympia", CountryId = 3 },
                new City() { CityName = "Berlin", CountryId = 4 },
                new City() { CityName = "Munich", CountryId = 4 },
                new City() { CityName = "Erlangen", CountryId = 4 },
                new City() { CityName = "Nurenburg", CountryId = 4 },
                new City() { CityName = "Hamburg", CountryId = 4 },
                new City() { CityName = "Frankfurt", CountryId = 4 },
                new City() { CityName = "Paris", CountryId = 5 },
                new City() { CityName = "Houston", CountryId = 6 },
                new City() { CityName = "New York", CountryId = 6 },
                new City() { CityName = "San Francisco", CountryId = 6 },
                new City() { CityName = "Las Vegas", CountryId = 6 },
                new City() { CityName = "Phoenix", CountryId = 6 },
                new City() { CityName = "Guanajuato", CountryId = 7 },
                new City() { CityName = "Savusavu", CountryId = 8 },
                new City() { CityName = "Tokyo", CountryId = 9 },
                new City() { CityName = "Taipei", CountryId = 10 },
                new City() { CityName = "Beijin", CountryId = 11 },
                new City() { CityName = "Munbai", CountryId = 12 }          // Total of 36 cities.
             );
            context.SaveChanges();



            ////    // ApplicationUser table seeder added by KI
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            if (!roleManager.RoleExists("Admin"))
               roleManager.Create(new Role { Name = "Admin" });

            if (!roleManager.RoleExists("User"))
                roleManager.Create(new Role { Name = "User" });


            IdentityResult result = null; // Initializing the result to null. result is used for error checking.

             //admin
            ApplicationUser user1 = userManager.FindByName("admin"); // setting user1 to a user data, if it exists

            if (user1 == null) // If user1 does not exist, then create and populate the properties. UserName property is added so the .FindByName will work (but I'm not 100% sure this is how it works.)
            {
                user1 = new ApplicationUser { FirstName = "Keigo", LastName = "Ito", UserName = "admin", Biography = "I hitch-hike & fish regularly.", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1982, 7, 20), CityId = 15, CountryId = 6, Gender = Gender.Male };
            }

            result = userManager.Create(user1, "asdfasdf"); // Create the user1 with the password "Monkey4!"
            if (!result.Succeeded) // if the .Create method is not successful, display the error message
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user1.Id, "Admin"); // Add the user1 to the Admini role
            user1 = userManager.FindByName("admin"); // Explicitly assign the user1 data to the variable user1

            //admin 2
            ApplicationUser user2 = userManager.FindByName("admin2");

            if (user2 == null)
            {
                user2 = new ApplicationUser() { FirstName = "Anna", LastName = "Cassaro", UserName = "admin2", Biography = "I love the river as well as traveling. GO CARDS!", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1991, 1, 10), CityId = 1, CountryId = 6 };
            }

            result = userManager.Create(user2, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user2.Id, "Admin");
            user2 = userManager.FindByName("admin2");

                //admin 3
            ApplicationUser user3 = userManager.FindByName("admin3");

            if (user3 == null)
            {
                user3 = new ApplicationUser { FirstName = "David", LastName = "Whaley", UserName = "admin3", Biography = "I'm from Indianapolis and love NASCAR!", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1989, 2, 2), CityId = 4, CountryId = 6 };
            }

            result = userManager.Create(user3, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user3.Id, "Admin");

            user3 = userManager.FindByName("admin3");

             //admin 4
            ApplicationUser user4 = userManager.FindByName("admin4");

            if (user4 == null)
            {
                user4 = new ApplicationUser { FirstName = "Rob", LastName = "Greenlee", UserName = "admin4", Biography = "I perform magic shows around the world.", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1991, 8, 13), CityId = 2, CountryId = 6 };
            }

            result = userManager.Create(user4, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user4.Id, "Admin");
            user4 = userManager.FindByName("admin4");

            //user 1
            ApplicationUser user5 = userManager.FindByName("user");

            if (user5 == null)
            {
                user5 = new ApplicationUser { FirstName = "Pablo", LastName = "Escabar", UserName = "user", Biography = "I'm very mysterious, that's all I can say.", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1970, 11, 27), CityId = 2, CountryId = 1 };
            }

            result = userManager.Create(user5, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user5.Id, "User");
            user5 = userManager.FindByName("user");

            //user 2
            ApplicationUser user6 = userManager.FindByName("user2");

            if (user6 == null)
            {
                user6 = new ApplicationUser { FirstName = "Bruce", LastName = "Willis", UserName = "user2", Biography = "Live hard, play hard, die hard!!", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1993, 9, 3), CityId = 2, CountryId = 6 };
            }

            result = userManager.Create(user6, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user6.Id, "User");
            user6 = userManager.FindByName("user2");

            //user 3
            ApplicationUser user7 = userManager.FindByName("user3");

            if (user7 == null)
            {
                user7 = new ApplicationUser { FirstName = "Inigo", LastName = "Montoya", UserName = "user3", Biography = "I will avenge my father. YOLO!", DateCreated = new DateTime(2015, 7, 8), Birthday = new DateTime(1972, 10, 31), CityId = 5, CountryId = 3 };
            }

            result = userManager.Create(user7, "asdfasdf");
            if (!result.Succeeded)
            {
                string error = result.Errors.FirstOrDefault();
                throw new Exception(error);
            }

            userManager.AddToRole(user7.Id, "User");
            user7 = userManager.FindByName("user3");        // Total of 7 users.

            Console.WriteLine("USER1 = " + user1.Id);

             ////CountryAlbum seeding modified by KI
            context.CountryAlbums.AddOrUpdate(
               a => a.CountryAlbumId,
               new CountryAlbum() { Description = "I traveled to Spain. I <3 Spain.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 1, UserId = user1.Id },
               new CountryAlbum() { Description = "Italy is such an amazing place!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 2, UserId = user1.Id },
               new CountryAlbum() { Description = "The mediterranean culture is wonderful.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 3, UserId = user1.Id },
               new CountryAlbum() { Description = "I traveled to Greece, pretty water.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 4, UserId = user1.Id },
               new CountryAlbum() { Description = "One of the most beautiful country I've ever visited.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 5, UserId = user1.Id },
               new CountryAlbum() { Description = "The shopping was fabulous!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 6, UserId = user1.Id },
               new CountryAlbum() { Description = "USA! USA! USA!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 1, UserId = user2.Id },
               new CountryAlbum() { Description = "I met some of the most wonderful people there.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 2, UserId = user2.Id },
               new CountryAlbum() { Description = "I loved the laid-back culture!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 3, UserId = user2.Id },
               new CountryAlbum() { Description = "The best sushi I've ever had.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 4, UserId = user2.Id },
               new CountryAlbum() { Description = "Interesting culture.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 5, UserId = user2.Id },
               new CountryAlbum() { Description = "The country with long and fascinating history.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 6, UserId = user2.Id },
               new CountryAlbum() { Description = "Food was great!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 1, UserId = user3.Id },
               new CountryAlbum() { Description = "The nature is so beautiful here.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 2, UserId = user3.Id },
               new CountryAlbum() { Description = "What an amazing place!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 3, UserId = user3.Id }, 
               new CountryAlbum() { Description = "People here know how to enjoy life!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 4, UserId = user4.Id },
               new CountryAlbum() { Description = "One of my favorite country to visit.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 5, UserId = user4.Id },
               new CountryAlbum() { Description = "I wish I can move here... Maybe someday...", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 6, UserId = user4.Id },
               new CountryAlbum() { Description = "Once-in-a-lifetime experience.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 1, UserId = user5.Id },
               new CountryAlbum() { Description = "You haven't lived until you come here.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 2, UserId = user5.Id },
               new CountryAlbum() { Description = "This is my comment1", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 3, UserId = user5.Id },
               new CountryAlbum() { Description = "This is my comment2", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 4, UserId = user6.Id },
               new CountryAlbum() { Description = "This is my comment3", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 5, UserId = user6.Id },
               new CountryAlbum() { Description = "This is my comment4.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 6, UserId = user6.Id },
               new CountryAlbum() { Description = "This is my comment5.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 7, UserId = user1.Id },
               new CountryAlbum() { Description = "This is my comment6.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 8, UserId = user1.Id },
               new CountryAlbum() { Description = "This is my comment7.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 9, UserId = user1.Id },
               new CountryAlbum() { Description = "This is my comment8.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 10, UserId = user7.Id },
               new CountryAlbum() { Description = "This is my comment9.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 11, UserId = user7.Id },
               new CountryAlbum() { Description = "This is my comment10.", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CountryId = 12, UserId = user7.Id }   // Total of 30 CountryAlbums 

               );
            context.SaveChanges();



            ////// CityAlbum seeding modified by KI
            context.CityAlbums.AddOrUpdate(
                a => a.CityAlbumId,
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 1, CountryAlbumId = 1 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 2, CountryAlbumId = 1 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 3, CountryAlbumId = 1 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 4, CountryAlbumId = 1 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 5, CountryAlbumId = 1 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 6, CountryAlbumId = 1 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 7, CountryAlbumId = 2 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 8, CountryAlbumId = 2 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 9, CountryAlbumId = 2 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 13, CountryAlbumId = 3 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 14, CountryAlbumId = 3 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 21, CountryAlbumId = 4 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 22, CountryAlbumId = 4 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 25, CountryAlbumId = 5 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 26, CountryAlbumId = 6 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 27, CountryAlbumId = 6 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 28, CountryAlbumId = 6 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 1, CountryAlbumId = 7 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 2, CountryAlbumId = 7 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 10, CountryAlbumId = 8 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 11, CountryAlbumId = 8 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 12, CountryAlbumId = 8 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 15, CountryAlbumId = 9 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 16, CountryAlbumId = 9 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 19, CountryAlbumId = 10 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 20, CountryAlbumId = 10 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 25, CountryAlbumId = 11 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 26, CountryAlbumId = 12 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 27, CountryAlbumId = 12 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 28, CountryAlbumId = 12 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 1, CountryAlbumId = 13 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 2, CountryAlbumId = 13 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 10, CountryAlbumId = 14 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 11, CountryAlbumId = 14 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 16, CountryAlbumId = 15 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 17, CountryAlbumId = 15 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 21, CountryAlbumId = 16 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 22, CountryAlbumId = 16 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 25, CountryAlbumId = 17 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 26, CountryAlbumId = 18 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 27, CountryAlbumId = 18 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 28, CountryAlbumId = 18 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 1, CountryAlbumId = 19 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 2, CountryAlbumId = 19 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 6, CountryAlbumId = 20 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 7, CountryAlbumId = 20 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 17, CountryAlbumId = 21 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 18, CountryAlbumId = 21 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 21, CountryAlbumId = 22 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 22, CountryAlbumId = 22 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 25, CountryAlbumId = 23 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 28, CountryAlbumId = 24 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went to Pearland and everywhere else!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 29, CountryAlbumId = 24 },
                new CityAlbum() { Title = "USA: Louisville", Description = "I went to Louisville and it was my favorite!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 30, CountryAlbumId = 24 },
                new CityAlbum() { Title = "USA: Athens", Description = "I went to Athens and ate peaches!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 31, CountryAlbumId = 25 },
                new CityAlbum() { Title = "Italy: Rome", Description = "I went to Rome and drank lots!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 32, CountryAlbumId = 26 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 33, CountryAlbumId = 27 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 34, CountryAlbumId = 28 },
                new CityAlbum() { Title = "Italy: Catania", Description = "I went to the market and met friends", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 35, CountryAlbumId = 29 },
                new CityAlbum() { Title = "USA: Houston", Description = "I went the rodeo!", DatePosted = new DateTime(2015, 7, 8), DateUpdated = new DateTime(2015, 7, 8), CityId = 36, CountryAlbumId = 30 }       // Total of 60 city albums
            );
            context.SaveChanges();

            ////// Pictures seeding modified by KI
            context.Pictures.AddOrUpdate(
               p => p.PictureId,
               new Picture() { UrlName = "http://seansimmonstravel.com.au/wp-content/uploads/2012/08/photodune-785712-hot-air-balloon-travel-over-andaman-sea-s.jpg", Caption = "Wonderful memory!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 1 },
               new Picture() { UrlName = "http://www.davidgiralphoto.com/data/photos/309_1travel_photography_south_03.jpg", Caption = "This place is amazing!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 1 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 1 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "Can't wait to come back!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 1 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 1 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 2 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 2 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 2 },
               new Picture() { UrlName = "http://risingjunkiri.com/wp-content/uploads/2014/12/destination-index21.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 2 },
               new Picture() { UrlName = "http://www.expatliving.sg/incoming/article59374.ece/alternates/w1024/_MG_3110.jpg", Caption = "When will I be back here again?", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 2 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 3 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 3 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "I met so many amazing people here!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 3 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "My favorite place on Earth.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 3 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 3 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 4 },
               new Picture() { UrlName = "http://www.travelmediakit.com/wp-content/themes/questex-travel/images/src/bg/travel-agents.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 4 },
               new Picture() { UrlName = "http://cdn.c.photoshelter.com/img-get/I00008qwShzEllq8/s/750/750/Vietnam-Travel-Photography-025.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 4 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "I met so many amazing people here!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 1, CityAlbumId = 5 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "What a sight!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 5 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 5 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "What a sight!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 6 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 6 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 1, CityAlbumId = 6 },
               new Picture() { UrlName = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSj1Uk4JBq0UQQWDWRscORnPWRd2__5WrAHjAVjdNz0stei2BHj6g", Caption = "Best trip I've had in decades.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 2, CityAlbumId = 7 },
               new Picture() { UrlName = "http://static1.squarespace.com/static/54398221e4b042b8855f0b24/55106db7e4b0561371d563ad/5510702ce4b05d3008c6f1bb/1427140654831/Vietnam-Southeast-Asia-Travel-Photographer-05-1.jpg?format=2500w", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 7 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "Wonderful memory!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 2, CityAlbumId = 7 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "I met so many amazing people here!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 8 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 8 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "What a sight!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 8 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 9 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 2, CityAlbumId = 9 },
               new Picture() { UrlName = "http://i.telegraph.co.uk/multimedia/archive/01555/travel-2010-cancun_1555024i.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 2, CityAlbumId = 9 },
               new Picture() { UrlName = "http://www.expatliving.sg/incoming/article59374.ece/alternates/w1024/_MG_3110.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 3, CityAlbumId = 10 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 3, CityAlbumId = 10 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "What a sight!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 3, CityAlbumId = 10 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 3, CityAlbumId = 11 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 3, CityAlbumId = 11 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 3, CityAlbumId = 11 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 4, CityAlbumId = 12 },
               new Picture() { UrlName = "http://www.travelmediakit.com/wp-content/themes/questex-travel/images/src/bg/index.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 4, CityAlbumId = 12 },
               new Picture() { UrlName = "http://www.davidgiralphoto.com/data/photos/309_1travel_photography_south_03.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 4, CityAlbumId = 13 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 4, CityAlbumId = 13 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 5, CityAlbumId = 14 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 5, CityAlbumId = 14 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 6, CityAlbumId = 15 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 6, CityAlbumId = 15 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 6, CityAlbumId = 16 },
               new Picture() { UrlName = "http://www.blogcdn.com/travel.aol.co.uk/media/2012/11/great-barrier-reef---tourism-australia-1352027874_640x426.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 6, CityAlbumId = 16 },
               new Picture() { UrlName = "http://static1.squarespace.com/static/54398221e4b042b8855f0b24/55106db7e4b0561371d563ad/5510702ce4b05d3008c6f1bb/1427140654831/Vietnam-Southeast-Asia-Travel-Photographer-05-1.jpg?format=2500w", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 6, CityAlbumId = 17 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 6, CityAlbumId = 17 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "So sad to leave such a wonderful place.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 7, CityAlbumId = 18 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 7, CityAlbumId = 18 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 7, CityAlbumId = 19 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 7, CityAlbumId = 19 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 8, CityAlbumId = 20 },
               new Picture() { UrlName = "http://www.jonesbros.com.au/wp-content/uploads/2013/12/travel-tahoe.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 8, CityAlbumId = 20 },
               new Picture() { UrlName = "http://www.expatliving.sg/incoming/article59374.ece/alternates/w1024/_MG_3110.jpg", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 8, CityAlbumId = 21 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 8, CityAlbumId = 21 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "When will I be back here again?", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 8, CityAlbumId = 22 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 9, CityAlbumId = 23 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 9, CityAlbumId = 24 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 10, CityAlbumId = 25 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "What a sight!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 10, CityAlbumId = 26 },
               new Picture() { UrlName = "http://www.newsnish.com/wp-content/uploads/2015/01/original_travel.jpg", Caption = "This place is amazing!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 11, CityAlbumId = 27 },
               new Picture() { UrlName = "http://www.davidgiralphoto.com/data/photos/309_1travel_photography_south_03.jpg", Caption = "Hanging out with the locals was so much fun!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 11, CityAlbumId = 27 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 12, CityAlbumId = 28 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "So cool!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 12, CityAlbumId = 29 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 12, CityAlbumId = 30 },
               new Picture() { UrlName = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRKo118CuhkXj2ZdKbxrZxkJgSr1jweAOl6i1pZA4pCd50sO48voQ", Caption = "I want to retire here.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 13, CityAlbumId = 31 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 13, CityAlbumId = 32 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "When will I be back here again?", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 14, CityAlbumId = 33 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 14, CityAlbumId = 34 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Best sunrise I've seen in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 15, CityAlbumId = 35 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 15, CityAlbumId = 36 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 16, CityAlbumId = 37 },
               new Picture() { UrlName = "http://i.telegraph.co.uk/multimedia/archive/01555/travel-2010-cancun_1555024i.jpg", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 16, CityAlbumId = 38 },
               new Picture() { UrlName = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRKo118CuhkXj2ZdKbxrZxkJgSr1jweAOl6i1pZA4pCd50sO48voQ", Caption = "My favorite place on Earth.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 17, CityAlbumId = 39 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 18, CityAlbumId = 40 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "I met so many amazing people here!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 18, CityAlbumId = 41 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 18, CityAlbumId = 42 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Best sunrise I've seen in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 19, CityAlbumId = 43 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 19, CityAlbumId = 44 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 20, CityAlbumId = 45 },
               new Picture() { UrlName = "http://www.travelmediakit.com/wp-content/themes/questex-travel/images/src/bg/index.jpg", Caption = "This place is amazing!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 20, CityAlbumId = 46 },
               new Picture() { UrlName = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRKo118CuhkXj2ZdKbxrZxkJgSr1jweAOl6i1pZA4pCd50sO48voQ", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 21, CityAlbumId = 47 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "So cool!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 21, CityAlbumId = 48 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "Best trip I've had in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 22, CityAlbumId = 49 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 22, CityAlbumId = 50 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "Best sunrise I've seen in decades.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 23, CityAlbumId = 51 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 24, CityAlbumId = 52 },
               new Picture() { UrlName = "http://wowslider.com/sliders/demo-25/data1/images/beautiful_nature.jpg", Caption = "When will I be back here again?", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 24, CityAlbumId = 53 },
               new Picture() { UrlName = "http://www.blogcdn.com/travel.aol.co.uk/media/2012/11/great-barrier-reef---tourism-australia-1352027874_640x426.jpg", Caption = "This trip has been a life-changing experience.", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 24, CityAlbumId = 54 },
               new Picture() { UrlName = "http://cdn.c.photoshelter.com/img-get/I00008qwShzEllq8/s/750/750/Vietnam-Travel-Photography-025.jpg", Caption = "My favorite place on Earth.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 25, CityAlbumId = 55 },
               new Picture() { UrlName = "http://s.ngm.com/2011/05/yosemite-climbing/img/potter-free-solo-heaven-615.jpg", Caption = "This place is amazing!", IsCityCoverPic = true, IsCountryCoverPic = true, CountryAlbumId = 26, CityAlbumId = 56 },
               new Picture() { UrlName = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Diani_Beach_Sunrise_Kenya.jpg", Caption = "Wonderful memory!", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 27, CityAlbumId = 57 },
               new Picture() { UrlName = "http://www.domestictourist.com/wp-content/uploads/2013/08/DSC_0103_edited.jpg", Caption = "So enjoyable.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 28, CityAlbumId = 58 },
               new Picture() { UrlName = "http://www.hdwallpapersos.com/wp-content/uploads/2014/07/Beach-Sunrise-In-Tathra-Australia.jpg", Caption = "My favorite place on Earth.", IsCityCoverPic = false, IsCountryCoverPic = false, CountryAlbumId = 29, CityAlbumId = 59 },
               new Picture() { UrlName = "http://www.dvd-ppt-slideshow.com/blog/wp-content/uploads/2010/03/free-easter-powerpoint-background-5.jpg", Caption = "No caption necessary.", IsCityCoverPic = true, IsCountryCoverPic = false, CountryAlbumId = 30, CityAlbumId = 60 }
               );
            context.SaveChanges();

            context.UserFollows.AddOrUpdate(
            c => c.UserFollowId,
            new UserFollow() { FromId = user1.Id, ToId = user2.Id },
            new UserFollow() { FromId = user1.Id, ToId = user3.Id },
            new UserFollow() { FromId = user1.Id, ToId = user4.Id },
            new UserFollow() { FromId = user2.Id, ToId = user3.Id },
            new UserFollow() { FromId = user2.Id, ToId = user4.Id },
            new UserFollow() { FromId = user2.Id, ToId = user5.Id },
            new UserFollow() { FromId = user3.Id, ToId = user4.Id },
            new UserFollow() { FromId = user4.Id, ToId = user5.Id },
            new UserFollow() { FromId = user5.Id, ToId = user6.Id },
            new UserFollow() { FromId = user7.Id, ToId = user4.Id },
            new UserFollow() { FromId = user2.Id, ToId = user1.Id },
            new UserFollow() { FromId = user3.Id, ToId = user1.Id },
            new UserFollow() { FromId = user4.Id, ToId = user1.Id },
            new UserFollow() { FromId = user5.Id, ToId = user1.Id },
            new UserFollow() { FromId = user7.Id, ToId = user1.Id }
            );
            context.SaveChanges();
        }

        
    }
}
