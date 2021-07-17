using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AimWare_V5_Loader
{
    public class moveform
    {
        internal class move
        {
            // Panel yada form hareket ettirme
            // İstenen dll'ler
            [DllImport("user32", CharSet = CharSet.Auto)]
            internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

            [DllImport("user32", CharSet = CharSet.Auto)]
            internal extern static bool ReleaseCapture();
        }
    }
}
/*****************************/
/*
 * Coder by '💛 💙Spoffer M10★#9400'
 * 
 * 
 * Coder by 'get good#2484'
 *
 * Bunny Loader geliştiren kişilerdir 
 * 
 * Destek veren 'MRX ✓#1337' en büyüğünden bir teşekkürederiz
 *
 */