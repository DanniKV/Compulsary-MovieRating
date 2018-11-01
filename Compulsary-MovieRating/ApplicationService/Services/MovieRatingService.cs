using System;
using System.Collections.Generic;
using System.Text;
using Compulsary_MovieRating.DomainService;
using MovieRating.Core.Entity;
using Newtonsoft.Json;
using Program;

namespace Compulsary_MovieRating.ApplicationService.Services
{
    public class MovieRatingService : IMovieRatingService
    {
        private const string FILE_NAME = "Test Ratings.Json";

        //Stuff needs to be implemented from TDD

        //Dep injection
        readonly IMovieRatingRepository _movieRepo;

        ReaderClass _jsonReader;

        public MovieRatingService(ReaderClass jsonReader)
        {
            _jsonReader = jsonReader;
        }

        //1
        public MovieRatings GetNumberOfReviewsFromReviewer(int Reviewer)
        {
            //for each movie rating X appears count up
            _jsonReader.JsonReader(FILE_NAME);
            
            throw new NotImplementedException();

        }

        //2
        public MovieRatings GetAverageReviewsFromReviewer(int Reviewer)
        {
            //for each movierating by int reviewer add them all
            //then divide by number for average
            throw new NotImplementedException();
        }

        //3
        public MovieRatings GetMovieGradeFromReviewerAndMovie(int Reviewer, int Movie)
        {
            //get grade from movierating when Reviewer(x) & Movie(y) matches
            throw new NotImplementedException();
        }

        //4
        public MovieRatings GetNumberOfReviewsFromMovie(int Movie)
        {
            //count all objects with the int Movie
            throw new NotImplementedException();
        }

        //5
        public MovieRatings GetAverageRateFromMovie(int Movie)
        {
            //get all objects with matching int movie and calculate average grade
            throw new NotImplementedException();
        }

        //6
        public MovieRatings GetNumberOfGradingFromMovieAndGrade(int Movie, int Grade)
        {
            //On two inputs, see how many times Movie (X) has recieved grade (Y)
            throw new NotImplementedException();
        }

        //7
        public MovieRatings GetMovieIdFromHighestGradedMovies(int Grade)
        {
            //Find which movie has the most "5 star ratings"
            throw new NotImplementedException();
        }


        //8
        public MovieRatings GetReviewerWithMostReviews(int Reviewer)
        {
            //Find the int Reviewer that appears the most
            throw new NotImplementedException();
        }

        //9
        public MovieRatings GetTopNMovies(int N)
        {
            //get top X amount of movies - Calculated by everythings average
            throw new NotImplementedException();
        }
  
  
        //10
        public List<MovieRatings> GetSortedMoviesFromReviewer(int Reviewer)
        {
            //Gets a sorted list by the integer of a reviewer.
            //It should be sorted by DECREASING GRADE and Date secondly
            throw new NotImplementedException();
        }
  
        //11
        public List<MovieRatings> GetReviewersSortedFromMovies(int Movie)
        {
            //Same as 10 but with Movies as the search parameter.
            throw new NotImplementedException();
        }
    }
}
