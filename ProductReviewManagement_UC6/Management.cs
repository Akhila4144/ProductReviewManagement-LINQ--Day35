using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagement_UC6
{
    public class Management
    {
        //public void RetrieveProductIdAndReviewOfAllRecords(List<ProductReview> review)
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              //select new { ProductId = products.ProductId, Review = products.Review });
            select products).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
    }
}
