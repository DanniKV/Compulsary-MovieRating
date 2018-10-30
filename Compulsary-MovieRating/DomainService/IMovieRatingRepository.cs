using MovieRating.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compulsary_MovieRating.DomainService
{
    public interface IMovieRatingRepository
    {
        //MovieRatingsRepository Interface!

        //Read Data

        //Made with Spiking.. prolly needs alterations and IEnumerable

        //1. On input N, what are the number of reviews from reviewer N?
        MovieRatings getNumberOfReviewsFromReviewer(int ReviewerId);

        //2. On input N, what is the average rate that reviewer N had given?
        MovieRatings getAverageReviewsFromReviewer(int ReviewerId);

        //3. On input N and G, how many times has reviewer N given a movie grade G?
        MovieRatings getMovieGradeFromReviewerAndMovie(int ReviewerId, int MovieId);

        //4. On input N, how many have reviewed movie N?
        MovieRatings getNumberOfReviewsFromMovie(int MovieId);

        //5. On input N, what is the average rate the movie N had received?
        MovieRatings getAverageRateFromMovie(int MovieId);

        //6. On input N and G, how many times had movie N received grade G?
        MovieRatings getNumberOfGradingFromMovieAndGrade(int MovieId, int Grade);

        //7. What is the id(s) of the movie(s) with the highest number of top rates(5)?
        MovieRatings getMovieIdFromHighestGradedMovies(int Grade);

        //8. What reviewer(s) had done most reviews?
        MovieRatings getReviewerWithMostReviews();

        //9. On input N, what is top N of movies? The score of a movie is its average rate.
        MovieRatings whatIsTheMeaningOfThis();

        /*10. On input N, what are the movies that reviewer N has reviewed? The list should
        be sorted decreasing by rate first, and date secondly. */
        List<MovieRatings> getSortedMoviesFromReviewer();

        /*11. On input N, what are the reviewers that have reviewed movie N? The list
        should be sorted decreasing by rate first, and date secondly.*/
        List<MovieRatings> getReviewersSortedFromMovies();

    }
}
