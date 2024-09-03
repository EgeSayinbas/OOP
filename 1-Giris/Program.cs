namespace _1_Giris
{
    public struct Kisi
    {
        public string Ad;
        public string Soyad;
        string _TcNo; //bos property
        
        public string Gsm;

        //kontrollu veri girisi tcno illa 11 olacak

        public void SetTcNo(string value) 
        {
            if(!string.IsNullOrEmpty(value)&& value.Length==11)
            {
                _TcNo = value;
            }
        }

        //TcNo son 4 hanesini gosterin
        //tcno kapsulleme. get ve set metodlari kosula bagli veri girisi cikisi  encapsulation
        public string GetTcNo()
        {
            if(!string.IsNullOrEmpty(_TcNo))
            {
                return _TcNo.Substring(7);
            }
            else
            {
                return "";
            }
        }

    }
    public class Personel
    {
        string _Tcno;
        string _Ad;
        public string Ad 
        { 
            get { return _Ad; }

            set
            {
                if (string.IsNullOrEmpty(_Ad))
                {
                    _Ad = value;
                }
            }
        }
        public string Soyad { get; set; }
        public string TcNo {
            get 
            {
                if (!string.IsNullOrEmpty(_Tcno))
                {
                    return _Tcno.Substring(7);
                }
                else
                {
                    return "";
                }
    
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _Tcno = value;
                }
            }
        }
        public string Gsm { get; set; } = string.Empty;
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region struct ile calismak
            Kisi kisi = new Kisi();
            kisi.Ad = "Ali";
            kisi.Soyad = "Yilmaz";
            kisi.SetTcNo ("12312312311");
            
            Console.WriteLine(kisi.GetTcNo());
            #endregion

            #region class ile calismak
            Personel personel = new();
            personel.Ad ="Veli";

            #endregion
        }
    }
}
