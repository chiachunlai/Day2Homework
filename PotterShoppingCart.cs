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

        public void AddToCart(Book book)
        {
            books.Add(book);
        }

        public float CheckOut()
        {
            float result = 0;
            // 將購買的書籍按不同的編號來分類，q是一個數列集合
            var q = books.GroupBy(x => x.ISBN).Select(x=> new { x.Key, NumBooks = x.Count() }).ToList();//.Sum(x => x.Price);
            // 買最多的數量
            int maxBuyCount = q.Max(x=>x.NumBooks);
            // 逐一比對
            for (int i = 0; i < maxBuyCount; i++)
            {
                // 取得湊組的數量
                var count = q.Where(x => x.NumBooks >= (i + 1)).Count();
                
                switch(count)
                {
                    case 1:
                        result += count * 100;
                        break;
                    case 2:
                        result += count * 0.95f * 100;
                        break;
                    case 3:
                        result += count * 0.9f * 100;
                        break;
                    case 4:
                        result += count * 0.8f * 100;
                        break;
                    case 5:
                        result += count * 0.75f * 100;
                        break;

                }
              
            }
           
            return result;
        }
        
           
    }
    //public class Book
}
