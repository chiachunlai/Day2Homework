using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{

    public class PotterShoppingCart
    {
        List<Book> books = new List<Book>();
        float[] discounts = new float[] {1, 0.95f, 0.9f, 0.8f, 0.75f};

        public void AddToCart(Book book)
        {
            books.Add(book);
        }

        public float CheckOut()
        {
            float result = 0;
            // 將購買的書籍按不同的編號來分類，q是一個數列集合
            var q = books.GroupBy(x => x.ISBN).ToDictionary(x => x.Key, x => x.ToList());

            // 買最多的數量
            int maxBuyCount = q.Max(x => x.Value.Count());

            // 逐一比對
            for (int i = 0; i < maxBuyCount; i++)
            {
                // 取得湊組的數量
                var count = q.Where(x => x.Value.Count() >= (i + 1)).Count();

                // 超過就維持5本的折扣
                count = (count > discounts.Count()) ? discounts.Count() : count;

                foreach (KeyValuePair<string, List<Book>> item in q)
                {
                    // 累加每本書的價格
                    if (item.Value.Count() >= i+1)
                        result += discounts[count - 1] * item.Value.First().Price;
                }
              
            }
           
            return result;
        }
        
           
    }
    //public class Book
}
