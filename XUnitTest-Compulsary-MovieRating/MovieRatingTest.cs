using Compulsary_MovieRating.ApplicationService;
using Compulsary_MovieRating.ApplicationService.Services;
using MovieRating.Core.Entity;
using Newtonsoft.Json;
using System;
using Program;
using Xunit;

namespace XUnitTest_Compulsary_MovieRating
{
    public class MovieRatingTest
    {
        private IMovieRatingService MovieR = new MovieRatingService(new ReaderClass("Test Ratings.json"));

        [Theory]
        [InlineData(1, 8)]
        public void TestGetNumberOfReviewsFromReviewer(int Input, int Result)
        {

        }

    }
}
