namespace Uebung_Lottozahlen
{
    internal class LottoGame
    {
        int hitsCount;
        int[] hits;

        public LottoGame(int hitsCount, int[] hits)
        {
            HitsCount = hitsCount;
            Hits = hits;
        }

        public int HitsCount { get => hitsCount; set => hitsCount = value; }
        public int[] Hits { get => hits; set => hits = value; }


    }
}
