using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.Entity;

namespace Compulsary_MovieRating.ApplicationService.Services
{
    public class MovieRatingService : IMovieRatingService
    {
        //Stuff needs to be implemented from TDD


        public MovieRatings getAverageRateFromMovie(int MovieId)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getAverageReviewsFromReviewer(int ReviewerId)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getMovieGradeFromReviewerAndMovie(int ReviewerId, int MovieId)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getMovieIdFromHighestGradedMovies(int Grade)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getNumberOfGradingFromMovieAndGrade(int MovieId, int Grade)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getNumberOfReviewsFromMovie(int MovieId)
        {
            throw new NotImplementedException();
        }

        public MovieRatings getNumberOfReviewsFromReviewer(int ReviewerId)
        {
            throw new NotImplementedException();
        }

        public List<MovieRatings> getReviewersSortedFromMovies()
        {
            throw new NotImplementedException();
        }

        public MovieRatings getReviewerWithMostReviews()
        {
            throw new NotImplementedException();
        }

        public List<MovieRatings> getSortedMoviesFromReviewer()
        {
            throw new NotImplementedException();
        }

        public MovieRatings whatIsTheMeaningOfThis()
        {
            throw new NotImplementedException();
        }
    }
}
