namespace Villa.Domain.Dtos
{
    public class BlogSeoDtoC 
    {
        public int? Id { get; set; }
        public int BlogId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AnahtarKelime { get; set; }
        public string HtmlMetaEtiket { get; set; }

    }
}