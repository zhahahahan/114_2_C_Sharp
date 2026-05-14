using System;

namespace Coin_Toss
{
    public class Coin
    {
        private Random rand = new Random();
        private string sideUp; // 儲存目前朝上的面

        public Coin()
        {
            sideUp = "Heads"; // 預設為正面朝上
        }

        public void Toss()
        {
            int side = rand.Next(2);
            sideUp = (side == 0) ? "Heads" : "Tails";
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
