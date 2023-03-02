
//Bu classı başka projede cağırmak için kullanacağımız projenin Dependencies'e sağa tıkla add project reference tıklayıp bu classı seciyoruz. Projenin içeinde using Class adı;(namespace) ekliyoruz. 

namespace Kalitim.Lib
{
    public class Kare : Sekil
    {
        public override double CevreHesapla()
        {
            return 4 * X;
        }
    }
}
