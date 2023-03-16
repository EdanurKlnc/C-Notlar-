using InterfaceOdemeSistemi.AbstractEntities;
using InterfaceOdemeSistemi.Interfaces;


namespace InterfaceOrnek_Odeme.Entities
{
    internal class KrediKartiylaOdeme : Odeme, IOdemeAlabilir
    {
        private string _kartSahibi;
        public string KartSahibi // Betül Akşan  Su Su harf olmalı 
        {
            get
            {
                return _kartSahibi;
            }
            set // atama yapılırken 
            {
                bool hepsiHarfMi = true;
                if (value.Length < 5)
                {
                    throw new Exception("Lütfen bilgilerinizi geçerli giriniz!");
                }
                foreach (var item in value)
                {
                    if (!char.IsWhiteSpace(item) && !char.IsLetter(item))
                    {
                        hepsiHarfMi = false;
                        break;
                    }
                }
                if (hepsiHarfMi == false) //!hepsiHarfMi
                {
                    throw new Exception("İsim soyisima lını harf olmalıdır!");
                }
                else
                {
                    _kartSahibi = value;
                }


            }

        }
        private string _kartNumarasi;
        public string KartNumarasi
        {
            get
            {
                return _kartNumarasi;
            }
            set // 0000 0000 0000 0000 
            {
                bool kuraliBozanVarMi = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (i == 4 || i == 9 || i == 14)
                    {
                        if (!char.IsWhiteSpace(value[i]))
                        {
                            kuraliBozanVarMi = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!char.IsDigit(value[i]))
                    {
                        kuraliBozanVarMi = true;
                        break;
                    }
                }

                if (value.Length != 19)
                {
                    throw new Exception("Kart numarası 16 haneli olmak zorundadır");
                }
                else if (kuraliBozanVarMi)
                {
                    throw new Exception("Kart numarası sadece rakamlardan oluşmalıdır!");
                }
                else
                {
                    _kartNumarasi = value;
                }
            }

        } //16 haneli rakamlar

        private byte _sonKullanimAy;
        public byte SonKullanimAy
        {
            get
            {
                return _sonKullanimAy;
            }
            set
            {
                if (value >= 1 && value <= 12) // value> 0 && value <13
                {
                    _sonKullanimAy = value;
                }
                else
                {
                    throw new Exception("Aylar 1 ile 12 arasında girilmelidir!");
                }
            }

        }
        private byte _sonKullanimYil;
        public byte SonKullanimYil
        {
            get
            {
                return _sonKullanimYil;
            }
            set
            {
                if (value > 22)
                {
                    _sonKullanimYil = value; //*****
                }
                else
                {
                    throw new Exception("Son Kullanım Yılını 2 haneli olacak şekilde girmeniz gerekmektedir! ");
                }
            }

        } // İki haneli olacak ÖRN :2023 --> 23
        public int CVC { get; set; }
        public decimal OdenecekTutar { get; set; }
        public string OdemeYap()
        {
            OdemeTarihi = DateTime.Now;

            return $"Kartınızdan ödeme alınmıştır... ";
        }
    }
}