using CoreDependencyInjection.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDependencyInjection.Services
{
    public class BookReviewRepository : IBookReviewRepository
    {
        public Guid Id { get; } = Guid.NewGuid();

        private BookReview[] _fakeData = new[]
        {
            new BookReview { Title = "Dr No", Rating = 1 },
            new BookReview { Title = "Dr No", Rating = 2 },
            new BookReview { Title = "Dr No", Rating = 4 },
            new BookReview { Title = "Goldfinger", Rating = 5 },
            new BookReview { Title = "Goldfinger", Rating = 4 },
            new BookReview { Title = "Goldfinger", Rating = 3 },
            new BookReview { Title = "Emma", Rating = 5 },
            new BookReview { Title = "Emma", Rating = 5 }
        };

        // private readonly BookReviewDbContext _dbContext;

        public BookReviewRepository(BookReviewDbContext dbContext)
        {
            //_dbContext = dbContext;
        }

        //public IEnumerable<BookReview> All => _dbContext.BookReviews;
        //public IEnumerable<BookReview> ByTitle(string title) => _dbContext.BookReviews.Where(r => r.Title == title);
        
        public IEnumerable<BookReview> All => _fakeData;
        public IEnumerable<BookReview> ByTitle(string title) => _fakeData.Where(r => r.Title == title);
    }
}
