
namespace AracTakip.Data
{
    public class EnvanterContext
    {
        public List<Marka> Markalar { get; set; } = new();
        public List<Model> Modeller { get; set; } = new();
        public List<Arac> Araclar { get; set; } = new();

        public Model? SearchModel(Func<Model, bool> predicate) //Func => geriye değer döndürdüğümüz için kullanıyoruz
        {
            return this.Modeller.FirstOrDefault(predicate);
        }


    }
}
