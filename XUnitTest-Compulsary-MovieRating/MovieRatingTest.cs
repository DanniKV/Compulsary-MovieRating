using Compulsary_MovieRating.ApplicationService;
using Compulsary_MovieRating.ApplicationService.Services;
using FileReader;
using MovieRating.Core.Entity;
using Newtonsoft.Json;
using System;
using Xunit;

namespace XUnitTest_Compulsary_MovieRating
{
    public class MovieRatingTest
    {
        private IMovieRatingService MovieR = new MovieRatingService(new JsonReadClass("Test Ratings.json"));

        [Theory]
        [InlineData] 
        public void Test1()
        {


        }
    }
}
