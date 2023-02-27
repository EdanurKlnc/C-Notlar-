using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WFormGiris
{
    public class Kisi
    {
        //ad, soyad, dogumTarihi, tckn, telefon, email, yas
        //Ad ve Soyad da özel karakter ve sayı olmamalı. Okunurken ilk harf büyük sonraki harfler küçük şekilde gösterilmeli
        //TCKN 11 haneli olmalı ve sadece rakamlardan oluşmalı
        //Telefon 10 haneli olmalı ve sadece rakamlardan oluşmalı
        //Email adresi @ işaretinden sonra en az 2 karakter olmalı ve email kurallarına uygun olmalı asd@asd
        //yas özelliği sadece okunur olmalı


        //fieladlar
        private string _ad;
        private string _soyad;
        private int _yas;
        private string _tc; //sayısal bir ifadeyi işlemsel kullanmıyorsan int yerine string alabiliriz
        private string _tel;
        private DateTime _dogumTarihi;
        private string _email;

        public string Ad //property
        {
            set
            {
                //stringi for veya foreach ile dönersen char verir
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsNumber(harf) || char.IsPunctuation(harf))
                        throw new Exception("Ad alanında sadece harf bulunmalıdır");

                }
                _ad = value;

            }
            get
            {
                // retrn _ad.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_ad); //Kelimenin ilk harfi büyük

                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower(); //0. indexten başla
                                                                                   //1 tane al büyüt gerisini kücült
            }

        }
        public string Soyad
        {
            set
            {
                //stringi for veya foreach ile dönersen char verir
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsNumber(harf) || char.IsPunctuation(harf))
                        throw new Exception("Soyad alanında sadece harf bulunmalıdır");

                }
                _soyad = value;

            }
            get
            {
                // retrn _ad.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_ad); //Kelimenin ilk harfi büyük

                return _soyad.ToUpper(); //Bütün harfleri büyük yazar

            }
        }
        public string Tc
        {
            set
            {
                if (value.Length != 11)

                    Console.WriteLine("HATA! TC Kimlik Numarası 11 Haneli Olmalıdır.");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TC sadece rakamlardan oluşmak zorunda");
                }
                _tc = value;
            }
            get { return _tc; }

        }

        public string Tel
        {
            set
            {
                if (value.Length != 10)

                    Console.WriteLine("HATA! Telefon Numarası 10 Haneli Olmalıdır.");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numarası sadece rakamlardan oluşmak zorunda");
                }
                _tel = value;
            }
            get { return _tel; }

        }
        public DateTime IslemTarihi { get; private set; } = DateTime.Now;
        public int Yas
        {
            get => DateTime.Now.Year - this.DogumTarihi.Year;
        }
        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            set
            {
                _dogumTarihi = value;

            }
        }
        public string Email
        {
            get => _email;

            set
            {
                string emailRegEx = @"^[\w -\.] +@([\w -] +\.)+[\w -]{ 2,4}$";
                if (!Regex.IsMatch(value, emailRegEx)) //Regex öze bir kütüphane
                {
                    throw new Exception("Geçerli bir mail adresi giriniz");

                }
                _email = value;
            }
        }


    }
}
