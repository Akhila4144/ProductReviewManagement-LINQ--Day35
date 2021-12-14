using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagementUC5
{
   public class Management
    {
       // public void RetrieveCountOfReviewForEachProductId(List<ProductReview> review)
        public void RetrieveProductIdAndReviewOfAllRecords(List<ProductReview> review)
        {
            //var recordData = review.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            var recordData = (from products in review
                             select new { ProductId = products.ProductId, Review = products.Review });
            
            foreach (var list in recordData)
            {
               // Console.WriteLine("Product Id : " + list.ProductId + " || Count : " + list.Count);
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
    }
}
