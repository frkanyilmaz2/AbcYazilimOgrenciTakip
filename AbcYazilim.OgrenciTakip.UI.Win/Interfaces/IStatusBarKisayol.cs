using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.UI.Win.Interfaces
{
    public interface IStatusBarKisayol : IStatusBarAciklama
    {
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
    }
}
