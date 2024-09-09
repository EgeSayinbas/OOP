using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    public enum KalipTipi
    {
        GomlekArka=1,
        GomlekOn=2,
        GomlekKol=3
    }
    internal class TopKumas:IKalip,IKesilebilir
    {
        public IMakine sonrakiStep { get; set; }
        private bool _flag;
        private KalipTipi _kalipTipi;
        public void KalipCikar(KalipTipi kalipTipi)
        {
            _kalipTipi = kalipTipi;
            Console.WriteLine("toptan kalip");
            _flag = true;
        }
        public void Kes()
        {
            //if (_flag) Console.WriteLine("Kesimden cikti");
            //else Console.WriteLine("kalip lazim");

            Console.WriteLine(_flag == true ? "Kesimden cikti" : "kalip lazim"); 
            switch(_kalipTipi)
            {
                case KalipTipi.GomlekArka:
                    
                    break;
                case KalipTipi.GomlekOn:
                    break;
                case KalipTipi.GomlekKol:
                    break;
                default:
                    break;
            }
        }
    }
}
