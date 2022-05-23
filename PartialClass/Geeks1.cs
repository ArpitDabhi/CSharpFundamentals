namespace PartialClass
{
    public partial class Geeks
    {
        private string authorName;
        private int totalArticles;

        public Geeks(string authorName, int totalArticles)
        {
            this.authorName = authorName;
            this.totalArticles = totalArticles;
        }
    }
}
