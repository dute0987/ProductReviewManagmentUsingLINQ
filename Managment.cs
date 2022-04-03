using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReviewMagementLinq
{
    public class Management
    {
        //UC-2
        public void TopRecordsList(List<ProductReview> review)
        {
            var recordData = (from productreviews in review
                              orderby productreviews.Rating descending
                              select productreviews).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId :" + list.ProductId + "UserId :" + list.UserId + "Rating :" + list.Rating + "Review :" + list.Review + "IsLike :" + list.IsLike);

            }
        }

        //UC-3
        public void SelectRecordsList(List<ProductReview> review)
        {
            var recordData = (from productreviews in review
                              where (productreviews.ProductId == 1 && productreviews.Rating > 3)
                              || (productreviews.ProductId == 4 && productreviews.Rating > 3)
                              || (productreviews.ProductId == 9 && productreviews.Rating > 3)
                              select productreviews);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId :" + list.ProductId + "UserId :" + list.UserId + "Rating :" + list.Rating + "Review :" + list.Review + "IsLike :" + list.IsLike);

            }
        }
        //UC-4
        public void CountOfReviews(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId :" + list.ProductId + "Count :" + list.Count);

            }
        }
        //Uc-5
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordPidReview = from product in listProductReview select (product.ProductId, product.Review);
            foreach (var list in recordPidReview)
            {
                Console.WriteLine("Product id : " + list.ProductId + " Review : " + list.Review);
            }
        }
        //UC-6
        public void SkipFiveRecord(List<ProductReview> listProductReview)
        {
            var records = (from product in listProductReview select product).Skip(5);
            foreach (var list in records)
            {
                Console.WriteLine("ProductID : " + list.ProductId + " UserID : " + list.UserId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " isLike : " + list.IsLike);
            }
        }

    }
}