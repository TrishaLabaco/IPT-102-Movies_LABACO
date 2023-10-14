using System;
using System.Collections.Generic;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel {
                Id = 1,
                Name = "Frozen",
                Rating = "9",
                ReleaseYear = 2023,
                Genre = "Animation/Comedy/ Adventure",
                Description = "When the newly crowned Queen Elsa accidentally uses her power to turn " +
                "things into ice to curse her home in infinite winter, her sister Anna teams up with " +
                "a mountain man, his playful reindeer, and a snowman to change the weather condition.",
                Images = "/Content/Images/Frozen.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=TbQm5doF_Uc"},


            new MovieViewModel {
                Id = 2,
                Name = "Taylor Swift: The Era's Tour",
                Rating = "10",
                ReleaseYear = 2023,
                Genre = "Music",
                Description = "Experience the breathtaking Eras Tour concert, performed by the one and " +
                "only Taylor Swift.",
                Images = "/Content/Images/Taylor.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=KudedLV0tP0"},



            new MovieViewModel {
                Id = 3,
                Name = "Barbie",
                Rating = "8",
                ReleaseYear = 2023,
                Genre = "Animation/Comedy/ Adventure",
                Description = "Barbie suffers a crisis that leads her to question her world and her existence.",
                Images = "/Content/Images/Barbie.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=pBk4NYhWNMM"},


            new MovieViewModel {
                Id = 4,
                Name = "Big Hero 6",
                Rating = "7",
                ReleaseYear = 2022,
                Genre = "Animation/Action",
                Description = "A special bond develops between plus-sized inflatable robot Baymax and prodigy " +
                "Hiro Hamada, who together team up with a group of friends to form a band of high-tech heroes.",
                Images = "/Content/Images/Bighero.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=z3biFxZIJOQ"},

            new MovieViewModel {
                Id = 5,
                Name = "Baymax",
                Rating = "8",
                ReleaseYear = 2023,
                Genre = "Animation/Comedy/ Adventure",
                Description = "The characters in the unique city of Big Hero 6 get their own series, " +
                "packed with adventures.",
                Images = "/Content/Images/Baymax.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=lcYPrMk12zw"},


            new MovieViewModel {
                Id = 6,
                Name = "Puss in Boots",
                Rating = "8",
                ReleaseYear = 2021,
                Genre = "Animation/Comedy/ Adventure/Family",
                Description = "When Puss in Boots discovers that his passion for adventure has taken its toll" +
                " and he has burned through eight of his nine lives, he launches an epic journey to restore them " +
                "by finding the mythical Last Wish.",
                Images = "/Content/Images/Boots.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=1esRrwrmWzA"},

            new MovieViewModel {
                Id = 7,
                Name = "The Little Mermaid",
                Rating = "9",
                ReleaseYear = 2023,
                Genre = "Animation/Fantasy",
                Description = "A young mermaid makes a deal with a sea witch to trade her beautiful voice for " +
                "human legs so she can discover the world above water and impress a prince.",
                Images = "/Content/Images/Mermaid.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=kpGo2_d3oYE"},


            new MovieViewModel {
                Id = 8,
                Name = "The Nun",
                Rating = "8",
                ReleaseYear = 2022,
                Genre = "Horror/Mystery/Thriller",
                Description = "956 - France. A priest is murdered. An evil is spreading. The sequel to the " +
                "worldwide smash hit follows Sister Irene as she once again comes face-to-face with Valak, " +
                "the demon nun",
                Images = "/Content/Images/Nun.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=QF-oyCwaArU"},


            new MovieViewModel {
                Id = 9,
                Name = "Insidious",
                Rating = "9",
                ReleaseYear = 2023,
                Genre = "Horror/Thriller",
                Description = " The Lamberts must go deeper into The Further than ever before to put their" +
                " demons to rest once and for all.",
                Images = "/Content/Images/Insidious.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=ZuQuOnYnr3Q"},


            new MovieViewModel {
                Id = 10,
                Name = "Finding Nemo",
                Rating = "7",
                ReleaseYear = 2020,
                Genre = "Animation/Comedy/ Adventure",
                Description = "TAfter his son is captured in the Great Barrier Reef and taken to Sydney, " +
                "a timid clownfish sets out on a journey to bring him home.",
                Images = "/Content/Images/Nemo.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=9oQ628Seb9w"},


            new MovieViewModel {
                Id = 11,
                Name = "The Lion King",
                Rating = "9",
                ReleaseYear = 2023,
                Genre = "Animation/Comedy/ Adventure",
                Description = "ion prince Simba and his father are targeted by his bitter uncle, " +
                "who wants to ascend the throne himself.",
                Images = "/Content/Images/Lion.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=7TavVZMewpY"},


            new MovieViewModel {
                Id = 12,
                Name = "Despicable Me 2",
                Rating = "7",
                ReleaseYear = 2022,
                Genre = "Animation/Comedy/ Adventure",
                Description = "When Gru, the world's most super-bad turned super-dad has been recruited " +
                "by a team of officials to stop lethal muscle and a host of Gru's own, He has to fight back " +
                "with new gadgetry, cars, and more minion madness.",
                Images = "/Content/Images/Me2.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=TlbnGSMJQbQ"},


             new MovieViewModel {
                Id = 13,
                Name = "Titanic",
                Rating = "10",
                ReleaseYear = 1912,
                Genre = "Drama/Romance",
                Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist " +
                "aboard the luxurious, ill-fated R.M.S. Titanic.",
                Images = "/Content/Images/Titanic.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=kVrqfYjkTdQ"},


            new MovieViewModel {
                Id = 14,
                Name = "Inception",
                Rating = "8",
                ReleaseYear = 2020,
                Genre = "Animation/Sci-Fi/ Adventure",
                Description = "A thief who steals corporate secrets through the use of dream-sharing " +
                "technology is given the inverse task of planting an idea into the mind of a C.E.O., " +
                "but his tragic past may doom the project and his team to disaster.",
                Images = "/Content/Images/Inception.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=Jvurpf91omw"},


            new MovieViewModel {
                Id = 15,
                Name = "The Shawshank Redemption",
                Rating = "9",
                ReleaseYear = 2019,
                Genre = "Animation/Comedy/ Adventure",
                Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, " +
                "redemption through basic compassion.",
                Images = "/Content/Images/Shaw.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=NmzuHjWmXOc"},


};
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return View("Error"); // Show the error view

            return View(movie);
        }

    }
}


