using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400076
{
    internal class KodePaket
    {
        public string getKodePaket(string namaPaket)
        {
            Dictionary<string, string> tabel = new Dictionary<string, string>() {
                {"Basic", "P201" },
                {"Standard", "P202" },
                {"Premium", "P203" },
                {"Unlimited", "P204" },
                {"Gaming", "P205" },
                {"Streaming", "P206" },
                {"Family", "P207" },
                {"Business", "P208" },
                {"Student", "P209" },
                {"Traveler", "P210" }
            };
            if (tabel.ContainsKey(namaPaket))
                return tabel[namaPaket];
            else
                return "Paket tidak ditemukan";
        }
    }
}
