using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class Megvalósítás
    {
        public void Start()
        {
            List<ILejátszható> lejátszhatók = new List<ILejátszható>();
            lejátszhatók.Add(new Film("gyerekkori nagyon vicces események", 0, 30, "Családias"));        //cím, ár, hossz, stílus       
            lejátszhatók.Add(new VásároltZene("Pataki Attila-Jegenyefák", 20, 4, "Mulatós"));
            lejátszhatók.Add(new Film("Shrek", 2500, 140, "Családias"));        //cím, ár, hossz, stílus
            lejátszhatók.Add(new Film("Forest Gump", 200, 137, "Családias"));        //cím, ár, hossz, stílus
            lejátszhatók.Add(new Film("Kapcsolat", 500, 150, "Családias"));        //cím, ár, hossz, stílus
            lejátszhatók.Add(new VásároltZene("Tankcscsapa-Mennyország Tourist", 200, 3, "Rock"));
            lejátszhatók.Add(new VásároltZene("Avicii-You make me", 5000, 4, "Elektronikus"));
            lejátszhatók.Add(new TorrentZene("Bunyós Pityu-Patkós tyúkot, fodros szoknya", 4, "Mulatós"));
            lejátszhatók.Add(new TorrentZene("Hardwell-Spacemen", 4, "Elektronikus"));
            lejátszhatók.Add(new TorrentZene("Hardwell-Blue Magic", 4, "Elektronikus"));
            lejátszhatók.Add(new TorrentZene("Iron Maiden-Number of the beast", 2, "Romantikus"));
            lejátszhatók.Add(new TorrentZene("Rómeó és Júlia-Lehetsz király", 4, "Romantikus"));
            lejátszhatók.Add(new TorrentZene("Rómeó és Júlia-Mit ér a hit?", 5, "Romantikus"));
            lejátszhatók.Add(new Film("Armageddon", 3000, 145, "Akció"));
            lejátszhatók.Add(new Film("A szállító", 3000, 145, "Akció"));
            lejátszhatók.Add(new Film("Bad Boys 2. – Már megint a rosszfiúk", 2000, 120, "Akció"));
            lejátszhatók.Add(new TorrentZene("Hardwell-Apollo", 4, "Elektronikus"));


            TartalomÖsszeállító t = new TartalomÖsszeállító();
            t.Start(lejátszhatók);
        }
    }
}