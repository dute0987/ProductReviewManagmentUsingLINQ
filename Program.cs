using ProductReviewMagementLinq; 
using System;
namespace ProductReviewManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review Management Problem Statement");
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 2, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 3, UserId = 4, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 4, UserId = 5, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 5, UserId = 6, Rating = 5, Review = "Good", IsLike = false },
                new ProductReview(){ProductId = 6, UserId = 7, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 8, UserId = 18, Rating = 5, Review = "Bad", IsLike = true },
                new ProductReview(){ProductId = 9, UserId = 17, Rating = 3, Review = "Good", IsLike = false },
                new ProductReview(){ProductId = 11, UserId = 9, Rating = 5, Review = "Bad", IsLike = true },
                new ProductReview(){ProductId = 13, UserId = 10, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview(){ProductId = 17, UserId = 11, Rating = 5, Review = "Good", IsLike = false },

            };
            //foreach (var list in listProductReview)
            //{
            //    Console.WriteLine("ProductId :" + list.ProductId + "UserId :" + list.UserId + "Rating :" + list.Rating + "Review :" + list.Review + "IsLike :" + list.IsLike);

            //}

            Management management = new Management();
            // management.TopRecordsList(listProductReview);
            //management.SelectRecordsList(listProductReview);
            //management.CountOfReviews(listProductReview);
            management.RetrieveProductIdAndReview(listProductReview);
            management.SkipFiveRecord(listProductReview);
        }
    }

}
