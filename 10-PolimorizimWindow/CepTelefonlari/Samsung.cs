using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorizimWindow.CepTelefonlari
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"..\..\..\Sounds\Sounds\samsung.wav"))
            {
                player.Play();
            }
        }
    }
}
