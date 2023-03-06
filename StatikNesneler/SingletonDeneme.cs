
namespace StatikNesneler
{
    public class SingletonDeneme
    {
        public Guid Id { get; set; } //Guid benzersiz özellik oluştururken kullanılan tip
        private static SingletonDeneme _singletonDeneme;
        private SingletonDeneme()
        {
            Thread.Sleep(10 * 1000);
            this.Id = Guid.NewGuid();
        }

        //1.yöntem
        public static SingletonDeneme GetInstance()
        {
            // return _singletonDeneme ??= new SingletonDeneme(); alttaki ifin başka kullanımı 
            if (_singletonDeneme == null)
                _singletonDeneme = new SingletonDeneme();
            return _singletonDeneme;
        }

        //2.yöntem
        public static SingletonDeneme Instance
        {
            get
            {
                if (_singletonDeneme == null)
                    _singletonDeneme = new SingletonDeneme();
                return _singletonDeneme;
            }
        }
    }
}
