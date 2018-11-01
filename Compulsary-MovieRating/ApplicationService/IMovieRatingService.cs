using MovieRating.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compulsary_MovieRating.ApplicationService
{
    public interface IMovieRatingService
    {
        //MovieRatingService Interface

        //Read
        //Some propably has to be made lists THIS IS MADE FROM SPIKING
        //Some prolly needs different parameters!

        //1. On input N, what are the number of reviews from reviewer N?
        MovieRatings GetNumberOfReviewsFromReviewer(int Reviewer);

        //2. On input N, what is the average rate that reviewer N had given?
        MovieRatings GetAverageReviewsFromReviewer(int Reviewer);

        //3. On input N and G, how many times has reviewer N given a movie grade G?
        MovieRatings GetMovieGradeFromReviewerAndMovie(int Reviewer, int Movie);

        //4. On input N, how many have reviewed movie N?
        MovieRatings GetNumberOfReviewsFromMovie(int Movie);

        //5. On input N, what is the average rate the movie N had received?
        MovieRatings GetAverageRateFromMovie(int Movie);

        //6. On input N and G, how many times had movie N received grade G?
        MovieRatings GetNumberOfGradingFromMovieAndGrade(int Movie, int Grade);

        //7. What is the id(s) of the movie(s) with the highest number of top rates(5)?
        MovieRatings GetMovieIdFromHighestGradedMovies(int Grade);

        //8. What reviewer(s) had done most reviews?
        MovieRatings GetReviewerWithMostReviews(int Reviewer);

        //9. On input N, what is top N of movies? The score of a movie is its average rate.
        MovieRatings GetTopNMovies(int N);

        /*10. On input N, what are the movies that reviewer N has reviewed? The list should
        be sorted decreasing by rate first, and date secondly. */
        List<MovieRatings> GetSortedMoviesFromReviewer(int Reviewer);

        /*11. On input N, what are the reviewers that have reviewed movie N? The list
        should be sorted decreasing by rate first, and date secondly.*/
        List<MovieRatings> GetReviewersSortedFromMovies(int Movie);
        
    }
}
