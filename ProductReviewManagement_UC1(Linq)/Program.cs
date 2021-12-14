using System;
using System.Collections.Generic;

namespace ProductReviewManagement_UC1_Linq_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem Statement");

            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=7,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=6,UserID=3,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductID=7,UserID=4,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=8,UserID=4,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=9,UserID=5,Rating=8,Review="Good",isLike=true},

            };

            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            Management management = new Management();

            //management.TopRecordsList(listProductReview);

            //management.SelectedRecords(listProductReview);
           
            management.RetrieveCountOfRecords(listProductReview);
        }
    }
}
