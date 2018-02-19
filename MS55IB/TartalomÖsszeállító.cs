using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class LáncoltLista<T> : IEnumerable<T> where T : ILejátszható
    {
        ListaElem<T> fej;

        public ListaElem<T> Fej
        {
            get { return fej; }
            set { fej = value; }
        }

        public LáncoltLista()
        {
            fej = null;
        }
        //A stílus szerinti rendezés egy switch-el van megoldva, mely az alábbiak szerint működik.
        //Minden egyes ágában van egy feltétel (mindbe kell, mivel nem tudni, milyen stípusú lesz a legelső elem), hogy amennyiben ez a stílus a legelső elem, akkor azt hozzáveszi a fej-hez. 
        //Utána létrehozok 2 segédváltozót amik a listaelemeken lépkednek és adott esetben új elemet fűznek a listához. Új elem úgy kerül a megfelelő helyére a listába, hogyha annak stílusa megeggyezik az éppen soron következő elem stílusával akkor pont elé szúródik be.
        //Így a beadott elemek közül mindig az azonos stílusú, de legutolsó elem kerül az élre.
        #region Stílus szerinti rendezés.
        public void RendezettenBetesz(T érték)
        {
            ListaElem<T> ujElem = new ListaElem<T>(érték);
            switch (érték.Stílus)
            {
                case "Családias":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Családias")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
                case "Mulatós":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Mulatós")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
                case "Romantikus":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Romantikus")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
                case "Nyálas":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Nyálas")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
                case "Akció":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Akció")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
                case "Rock":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Rock")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;

                case "Elektronikus":
                    if (fej == null)
                    {
                        fej = ujElem;
                    }
                    else
                    {
                        ListaElem<T> p = fej;
                        ListaElem<T> e = null;
                        while (p != null && p.Érték.Stílus != "Elektronikus")
                        {
                            e = p;
                            p = p.Következő;
                        }
                        if (e == null)
                        {
                            ujElem.Következő = fej;
                            fej = ujElem;
                        }
                        else
                        {
                            ujElem.Következő = p;
                            e.Következő = ujElem;
                        }
                    }
                    break;
            }
        }
        #endregion

        public void Beszuras(T ujErtek)
        {
            ListaElem<T> ujElem = new ListaElem<T>(ujErtek);
            if (fej == null)
                fej = ujElem;
            else
            {
                ListaElem<T> p = fej;
                while (p.Következő != null)
                    p = p.Következő;
                p.Következő = ujElem;
            }
        }

        public void BackTrack(ref int műsorhossz, ref int totalcost, ref int marker, ILejátszható[] eredmeny)
        {
            ListaElem<ILejátszható> start = null;
            BackTrack(fej, 0, limit, 0, eredmeny, ref limit, ref totalcost, ref marker, start);
            BackTrack(ref fej, 0, műsorhossz, eredmeny);
            //BackTrack(fej,)
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new LáncoltListaEnumerátor<T>(fej);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    /*
     * Backtrackhez: 
     * majd akkor
mikor jön a BT
ugye ott az van
hogy a felhasználó megasszondja
milyen stílusokat akar
egyáltalán válogattatni
te meg ez alapján a referencia tömböd alapján
nem kell
mindig elejéről végigmenned
hanem rögtön odaugrasz
és elkezded kiszedni adott stilust
de ha balfasz felhasználó asszondja szeretne olyat, ami létezik mint stilus a rendszeredbe
de nincs hozzárendelt film/zene
akkor throw
szal a BT
lesz a try
végére catch
azt máris írhatod ki
a megadott stílus nem létezik/stílusok közül egy nem létezik
     * */
    class TartalomÖsszeállító
    {
        ListaElem<ILejátszható> fej;

        public ListaElem<ILejátszható> Fej
        {
            get { return fej; }
            set { fej = value; }
        }
        LáncoltLista<ILejátszható> tartalom;

        internal LáncoltLista<ILejátszható> Tartalom
        {
            get { return tartalom; }
            set { tartalom = value; }
        }

        public void Start(List<ILejátszható> input)
        {
            int length = input.Count;
            LáncoltLista<ILejátszható> tartalom = new LáncoltLista<ILejátszható>();

            for (int i = 0; i < length; i++)
            {
                tartalom.RendezettenBetesz(input[i]);
            }
            //A foreach működése: var értékek in tartalom
            /*
             * Első lépésként a tartalom "parancsra" meghívódik az IEnumerable<T> interface-t megvalósító LáncoltLista<T> osztály-ban a GetEnumerator() metódus, melynek egyetlen eleme a visszatérési értéke, a LáncoltListaEnumerátor<T> osztály, melynek
             * bemenő paramétere a listánk feje.
             *A LáncoltListaEnumerátor<T> megvalósítja az INumerator<T> interface-t ami miatt meg kell írni a Current, MoveNext, Reset metódusokat. 
             *A LáncoltListaEnumerátor<T> osztály tartalmaz két ListaElem<T> típusú elemet, az aktualis-t és az elso-t. A konstruktorban az elso-nek átadódik a teljes láncolt listánk, az aktualis értéke null.
             * Második lépésként az in "parancsra" a MoveNext() metódus hívódik meg, ami első lépésként az aktualisnak átadja a teljes listánkat, majd újabb meghíváskor, már csak elementként lépteti a listát.
             * Visszatérési értéke bool, jelzi hogy maradt e még elemünk a listában, ha ez hamis, leáll a foreach ciklus.
             * Utolsó lépésben a var érték fut le, ami a Current() metódusból visszaadja az -aktualis- listaelem érték tulajdonságát.
             * 
             * */
            foreach (var érték in tartalom)
            {
                Console.WriteLine(érték);       //Kiiratáskor a Film osztályban található ToString metódus fut le, mivel minden osztály tulajdonsága onnan olvasható ki.
            }
            Console.WriteLine();
            Console.WriteLine();
            ILejátszható[] elsőelemreReferencia = Elsőelemre(tartalom);

            foreach (var item in elsőelemreReferencia)
            {
                Console.WriteLine(item);
            }
            TartalomÖsszeállítás(tartalom);

            /*
             * 
             *     /*
     * Backtrackhez: 
     * majd akkor
mikor jön a BT
ugye ott az van
hogy a felhasználó megasszondja
milyen stílusokat akar
egyáltalán válogattatni
te meg ez alapján a referencia tömböd alapján
nem kell
mindig elejéről végigmenned
hanem rögtön odaugrasz
és elkezded kiszedni adott stilust
de ha balfasz felhasználó asszondja szeretne olyat, ami létezik mint stilus a rendszeredbe
de nincs hozzárendelt film/zene
akkor throw
szal a BT
lesz a try
végére catch
azt máris írhatod ki
a megadott stílus nem létezik/stílusok közül egy nem létezik
     * 
             * 
             * 
             * BT
             * a lancolt lista egyik metodusa
mivel minden lancolt lista-ban lehet keresni a megközés miatt
             * mert úgy van felépítve a programom, hogy a láncolt listámban a bts működni fog
mert csak olyan elemek lehetnek benne, amivel a bts működik
9 paraméteres BTS
ebből 3 vagy 4 ref paraméterrel 
             * meghívom a műfajra kiválogatott listán
ami már csak azokat a műfajokat tartalmazza
amiket a felhasz engedett
abban megnézi az első belefér-e az időbe
ha igen, megnézi a másodikkal belefér-e az időbe
ha valami belefér
azt kimentem egy olyan lista node-ba
aminek a tartalma az adott listaelem tartalmára mutat, a next része meg az előtte ellenőrzött
listaelemére
amennyiben találok egy optimális megoldás (az első megtalált mindig optimális lesz)
(utána meg az előző optimálishoz hasonlít mindig)
szal ha talál egy éppen legjobb megoldást
akkor a mappoint listnode-okon
visszaköveti
milyen listaelemeken keresztül jutott el oda
azok tartalmát egy tömbbe
Eredmeny() metódusban
feltölti
ha a megtalált megoldás nem a legjobb
tehát nem jobb mint az előző
akkor
semmit nem csinál, keres tovább
csak akkor változtat az eredményen
a tömbön
ha jobb megoldást talál
akkor viszont beállítgatja az eredmény tömböt megfelelően
és a markert
a marker egy olyan változó ami azt jelöli, hogy az eredmény tömbben
meddig kell nézni
a cuccot
mert ha régen 7 elem volt a jó megoldás, de később 2 elem a legjobb
akkor a maradék 5 elem már nem kell kiíratásnál
amennyiben egy elem sem felel az egész tömb null referenceket fog tartalmazni
annyi, hogy kell egy ilyen konstruktor a Node-od nak, amit a láncolt listára használsz még:
public ListNode(ListNode<T> next)
        {
            tartalom = default(T);
            this.next = next;
        }
meg a T tartalom tulajdonságot
írhatóvá is kell tenni
és ezzel megoldható a visszakeresése a megoldásnak
             * node - vizsgált listelem
szint - az aktuális választás szintje, az az index ahanyadik kiválasztott lehetséges elem
remaining - maradék idő, ami hátra van, hogy elérjem a műsoridőt
cost - ár
eredmeny - az eredménytömb, melybe az éppen legjobb megoldásokat beállítom
ref int pool - az éppen aktuális legjobb megoldás és műsoridő közti eltérés
ref int totalcost - az éppen aktuális legjobb megoldás ára
ref int marker - az éppen aktuális legjobb megoldás utolsó elemét mutatja meg az eredmény tömbben
(azért kell, mert ha előtte 5 elem volt a legjobb, most meg csak kettő, akkor az első 2 elemet átállítom a tömbben, de tudnom kell, hogy csak az első kettőt kell figyelembe vennem a további feldolgozásnál)
before - az előző szinten vizsgált elemre mutató referencia, hogy vissza tudjam követni milyen elemeken keresztül találtam legjobb megoldásokat
             * 
             * a bts-em
            a this helyett
            nálad
            a ref totalcost
            llenne
            a te verziodban
             * **/


        }
        //Az elsőelemek megtalálása: egy int db változóba eltárolom a tartalom méretét, majd a egy tmp tömböt ezzel a mérettel inicializálok. Ebbe a tmp tömbbe kerülnek bele a referenciák.
        //A megvalósítás:Először feltöltöm a tömböt a tartalom összes elemével, majd  deklarálok egy index változót ami a legelső elemre mutat, és ezt is használom az if első vizsgálandó elemének indexelésére. 
        //Amíg a soron következő elemek stílusa azonos az elsővel, addig azokat törlöm, ha különböznek, akkor az index értéket fölülírom az i-vel így az az éppen aktuális elemre fog mutatni, aminek pont eltér a stílusa
        //az eddig vizsgálttól. Ezután folytatódik a ciklus és vizsgálja, hogy a következő elem azonos-e az index-edik elem stílusával és ha igen, törli, ha nem átlépteti az indexet az aktuális elemre és így tovább.


        public void TartalomÖsszeállítás(LáncoltLista<ILejátszható> tartalom)
        {
            int stilusDb = 0;
            int támogatott_index = 0;
            try
            {
                stilusDb = Db();
            }
            catch (TulnagyASzam e)
            {
                Console.WriteLine(e.Message);
                TartalomÖsszeállítás(tartalom);
            }

            Console.WriteLine();
            string[] támogatottStílusok = new string[stilusDb];     //meghívom a műfajra kiválogatott listán ami már csak azokat a műfajokat tartalmazza amiket a felhasz engedett          
            bool kilep = false;
            while (kilep == false)
            {
                try
                {
                    támogatottStílusok = TámogatottStílusok(stilusDb, támogatott_index);
                    kilep = true;
                }
                catch (NemLetezoStilus e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine();
            int műsorhossz = 0;

            Dictionary<string, List<ILejátszható>> válogatottTartalom = Válogatás(tartalom, támogatottStílusok);
            LáncoltLista<ILejátszható> osszefuzott = new LáncoltLista<ILejátszható>();
            osszefuzott = ElejereOsszeFuzes(válogatottTartalom);
            int meret = osszefuzott.Count();
            int marker = 0;
            ILejátszható[] eredmeny = new ILejátszható[meret];
            //osszefuzott.BackTrack()
            
            Console.WriteLine();

            foreach (var item in osszefuzott)
            {
                Console.WriteLine(item);
            }
        }
        public LáncoltLista<ILejátszható> ElejereOsszeFuzes(Dictionary<string, List<ILejátszható>> válogatottTartalom)
        {
            //ListaElem<T> fej = válogatottTartalom.Values;
            LáncoltLista<ILejátszható> osszefuzott = new LáncoltLista<ILejátszható>();

            foreach (var item in válogatottTartalom)
            {
                if (item.Value.Count != 0)
                {
                    for (int j = 0; j < item.Value.Count; j++)
                    {
                        osszefuzott.Beszuras(item.Value[j]);
                    }
                }
            }
            //for (int i = 0; i < válogatottTartalom.Values.Count; i++)
            //{
            //    if (válogatottTartalom.Keys != null)
            //    {
            //        Console.WriteLine("null");
            //    }
            //}
            return osszefuzott;
        }
        //public void BackTrack(ref int limit, ref int totalcost, ref int marker, ILejátszható[] eredmeny)
        //public void BackTrack(ref int műsorhossz, ref int totalcost, ref int marker, ILejátszható[] eredmeny)
        //{
        //    ListaElem<ILejátszható> start = null;
        //    BackTrack(fej, 0, limit, 0, eredmeny, ref limit, ref totalcost, ref marker, start);
        //    BackTrack(fej,0,műsorhossz,)
        //    //BackTrack(fej,)
        //}
        private void BackTrack(ListaElem<ILejátszható> fej, int szint, int remaining, int cost, ILejátszható[] eredmeny, ref int pool, ref int totalcost, ref int marker, ILejátszható before)
        {
            ListaElem<ILejátszható> mappoint = new ListaElem<ILejátszható>(before);
            int temptime;
            int tempcost;
            while (fej != null)
            {
                mappoint.Érték = fej.Érték;
                temptime = remaining - fej.Érték.Hossz;
                tempcost = cost + fej.Érték.SzerzőiJogdíj;
                if (temptime >= 0)
                {
                    BackTrack(fej.Következő, szint + 1, temptime, tempcost, eredmeny, ref pool, ref totalcost, ref marker, mappoint);
                    if (temptime < pool)
                    {
                        pool = temptime;
                        totalcost = tempcost;
                        marker = szint;
                        Eredmeny(szint, eredmeny, mappoint);
                    }
                    else if (temptime == pool && tempcost < totalcost)
                    {
                        totalcost = tempcost;
                        marker = szint;
                        Eredmeny(szint, eredmeny, mappoint);
                    }
                }
            }
        }
        private void Eredmeny(int szint, ILejátszható[] eredmeny, ListaElem<ILejátszható> map)
        {
            ListaElem<ILejátszható> temp = map;
            while (temp != null)
            {
                eredmeny[szint] = temp.Érték;
                temp = temp.Következő;
                szint--;
            }
        }

        public int Db()
        {
            Console.Write("Hány stílusra kíván keresni? \t");
            int stilusDb = 0;
            try
            {
                stilusDb = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Megfelelő formát használjon!");
                Console.Clear();
            }
            if (stilusDb < 1 || stilusDb > 6)
            {
                throw new TulnagyASzam("Csak 1 és 6 közötti számot adjon meg!");
            }
            return stilusDb;
        }


        public string[] TámogatottStílusok(int stilusDb, int támogatott_index)
        {
            Console.Write("Válasszon stílust/stílusokat!\n");
            Console.WriteLine("Családias, Mulatós, Akció, Rock, Elektronikus, Romantikus");

            string[] stilusok = new string[stilusDb];
            for (int i = 0; i < stilusDb; i++)
            {
                #region stílusválasztás
                string a = Console.ReadLine();
                switch (a)      //ÁTírni Láncolt listás feltöltsére
                {
                    case "Családias":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Mulatós":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Akció":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Rock":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Elektronikus":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Romantikus":
                        stilusok[támogatott_index++] = a;
                        break;
                    default:
                        throw new NemLetezoStilus("Ilyen stílus nem létezik!");
                }
                #endregion
            }
            return stilusok;
        }

        public ILejátszható[] Elsőelemre(LáncoltLista<ILejátszható> tartalom)
        {
            ListaElem<ILejátszható> aktualis = tartalom.Fej;
            //6 stílust használok, ezáltal 6 elemű a tömbböm, amibe eltárolom az első elemre vonatkozó referenciákat.
            string[] stilusok = new string[] { "Családias", "Mulatós", "Rock", "Elektronikus", "Romantikus", "Akció" };
            int stilus_index = 0;
            int db = stilusok.Length;
            ILejátszható[] elsőelemekreRef = new ILejátszható[db];
            int elsőre_index = 0;
            while (stilus_index < db && aktualis != null)
            {
                if (aktualis.Következő == null && elsőelemekreRef[elsőre_index] == null)
                {
                    stilus_index += 2;
                    aktualis = tartalom.Fej;
                    elsőelemekreRef[elsőre_index++] = aktualis.Érték;
                }
                else if (aktualis.Érték.Stílus == stilusok[stilus_index])
                {
                    elsőelemekreRef[elsőre_index++] = aktualis.Érték;
                    stilus_index++;
                }
                aktualis = aktualis.Következő;
            }
            return elsőelemekreRef;
        }


        public Dictionary<string, List<ILejátszható>> Válogatás(LáncoltLista<ILejátszható> tartalom, string[] támogatott)
        {
            Dictionary<string, List<ILejátszható>> adatok = new Dictionary<string, List<ILejátszható>>();

            adatok.Add("Családias", new List<ILejátszható>());
            adatok.Add("Mulatós", new List<ILejátszható>());
            adatok.Add("Rock", new List<ILejátszható>());
            adatok.Add("Elektronikus", new List<ILejátszható>());
            adatok.Add("Romantikus", new List<ILejátszható>());
            adatok.Add("Akció", new List<ILejátszható>());

            for (int i = 0; i < támogatott.Count(); i++)
            {
                foreach (ILejátszható item in tartalom)
                {
                    if (item.Stílus == támogatott[i])
                    {
                        adatok[támogatott[i]].Add(item);
                    }
                }
            }
            return adatok;
        }
    }
}



//Fel nem használt kódok!!!!!
//public static void Kiirat(LáncoltLista<ILejátszható> tartalom)
//      {
//          ListaElem<ILejátszható> aktualis = tartalom.Fej;
//          while (aktualis != null)
//          {
//              Console.WriteLine(aktualis.Érték);
//              aktualis = aktualis.Következő;
//          }

//      }

//        public static LáncoltLista<ILejátszható> ElsőElem(LáncoltLista<ILejátszható> tartalom)
//        {
//            int db = tartalom.Count<ILejátszható>();
//            ILejátszható[] tmp = new ILejátszható[db];
//            LáncoltLista<ILejátszható> temp = new LáncoltLista<ILejátszható>();
//            int i = 0;
//            foreach (var érték in tartalom)
//            {
//                tmp[i] = érték;
//                i++;
//            }
//            temp.UjElemFelvetele(tmp[0]);

//            int index = 0;
//            for (i = 1; i < db; i++)
//            {
//                if (tmp[index].Stílus == tmp[i].Stílus)
//                {
//                    tmp[i] = null;
//                }
//                else index = i;
//            }

//            i = 1;
//            for (index = 1; index < db; index++)
//            {
//                if (tmp[index - 1] == null || tmp[index] != null)
//                {
//                    while (index < db && tmp[index] == null)
//                    {
//                        index++;
//                    }
//                    if (index == db) break;
//                    temp.UjElemFelvetele(tmp[index]);
//                    tmp[i] = tmp[index];
//                    i++;
//                    tmp[index] = null;
//                    index = i + 1;
//                }
//            }
//            return temp;

//        }
/*
 * 
 *  public LancoltLista<string> TamogatottStilusok(int stilusDb)
        {
            Console.Write("Válasszon stílust/stílusokat!\n");
            Console.WriteLine("Családias, Mulatós, Akció, Rock, Elektronikus, Romantikus");
            LancoltLista<string> tamogatottak = new LancoltLista<string>();
            for (int i = 0; i < stilusDb; i++)
            {
                #region stílusválasztás
                string a = Console.ReadLine();
                switch (a)      //ÁTírni Láncolt listás feltöltsére
                {
                    case "Családias":
                        tamogatottak.Beszuras(a);
                        break;
                    case "Mulatós":
                        tamogatottak.Beszuras(a);
                        break;
                    case "Akció":
                        tamogatottak.Beszuras(a);
                        break;
                    case "Rock":
                        tamogatottak.Beszuras(a);
                        break;
                    case "Elektronikus":
                        tamogatottak.Beszuras(a);
                        break;
                    case "Romantikus":
                        tamogatottak.Beszuras(a);
                        break;
                    default:
                        throw new NemLetezoStilus("Ilyen stílus nem létezik!");
                }
                #endregion
            }
            return tamogatottak;
        }
 * 
 * //while (stilusDb == 0)
            //{
            //    try
            //    {
            //        stilusDb = Db();
            //    }
            //    catch (TulnagyASzam e)
            //    {
            //        Console.WriteLine(e.Szoveg);
            //        //   Console.WriteLine(e.Message);
            //        TartalomÖsszeállítás(tartalom);
            //    }
            //}
 * 
 *  public void ElemTörlése(ILejátszható elem)
        {
            if (fej != null)
            {
                ListaElem<T> aktuális = fej;
                ListaElem<T> előző = null;

                while (aktuális != null && !aktuális.Érték.Equals(elem)) //mert az aktuális.Érték != játékot nem engedi használni
                {
                    előző = aktuális;
                    aktuális = aktuális.Következő;
                }
                if (aktuális != null)
                {
                    if (előző == null) //akkor a fejet kell törölni
                        fej = aktuális.Következő;
                    else
                        előző.Következő = aktuális.Következő;
                }
            }
        }/*/
/*
 * 
 *  public void BackTrack(ref int limit, ref int totalcost, ref int marker, ILejátszható[] eredmeny)
        {
            ListNode<ILejátszható> start = null;
            BackTrack(fej, 0, limit, 0, eredmeny, ref limit, ref totalcost, ref marker, start);
        }
        private void BackTrack(ListaElem<ILejátszható> fej, int szint, int remaining, int cost, ILejátszható[] eredmeny, ref int pool, ref int totalcost, ref int marker, ListaElem<ILejátszható> before)
        {
            ListNode<ILejátszható> mappoint = new ListNode<ILejátszható>(before);
            int temptime;
            int tempcost;
            while (fej != null)
            {
                mappoint.Tartalom = fej.Tartalom;
                temptime = remaining - fej.Tartalom.Hossz;
                tempcost = cost + fej.Tartalom.SzerzőiJogdíj;
                if (temptime >= 0)
                {
                    BackTrack(fej.Next, szint + 1, temptime, tempcost, eredmeny, ref pool, ref totalcost, ref marker, mappoint);
                    if (temptime < pool)
                    {
                        pool = temptime;
                        totalcost = tempcost;
                        marker = szint;
                        Eredmeny(szint, eredmeny, mappoint);
                    }
                    else if (temptime == pool && tempcost < totalcost)
                    {
                        totalcost = tempcost;
                        marker = szint;
                        Eredmeny(szint, eredmeny, mappoint);
                    }
                }
            }
        }
 * 
 *   //foreach (var item in válogatottTartalom)
            //{
            //    if (item.Value.Count != 0)
            //    {
            //        try
            //        {
            //            //BT
            //        }
            //        catch (Exception e)
            //        {
            //            throw new Exception("A megadott stílus nem létezik/stílusok közül egy nem létezik.");
            //        }
            //        for (int j = 0; j < item.Value.Count; j++)
            //        {
            //          //  Console.WriteLine(item.Value[j]);
            //        }
            //    }
            //}

 * 
 *    public string[] TámogatottStílusok(int stilusDb, int támogatott_index)
        {
            Console.Write("Válasszon stílust/stílusokat!\n");
            Console.WriteLine("Családias, Mulatós, Akció, Rock, Elektronikus, Romantikus");

            string[] stilusok = new string[stilusDb];
            for (int i = 0; i < stilusDb; i++)
            {
                #region stílusválasztás
                string a = Console.ReadLine();
                switch (a)      //ÁTírni Láncolt listás feltöltsére
                {
                    case "Családias":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Mulatós":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Akció":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Rock":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Elektronikus":
                        stilusok[támogatott_index++] = a;
                        break;
                    case "Romantikus":
                        stilusok[támogatott_index++] = a;
                        break;
                    default:
                        throw new NemLetezoStilus("Ilyen stílus nem létezik!");
                }
                #endregion
            }
            return stilusok;
        }
 * **/
/*
 *     //class LancoltLista<T>: IEnumerable<T> where T: ILejátszható
    //{
    //    ListaElem<T> fej;

    //    public ListaElem<T> Fej
    //    {
    //        get { return fej; }
    //        set { fej = value; }
    //    }

    //    public LancoltLista()
    //    {
    //        fej = null;
    //    }
    //    public void Beszuras(T ujErtek)
    //    {
    //        ListaElem<T> ujElem = new ListaElem<T>(ujErtek);
    //        if (fej == null)
    //            fej = ujElem;
    //        else
    //        {
    //            ListaElem<T> p = fej;
    //            while (p.Következő != null)
    //                p = p.Következő;
    //            p.Következő = ujElem;
    //        }
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        return new LancoltListaEnumerator<T>(fej);
    //    }

    //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    //    {
    //        return  this.GetEnumerator();
    //    }
    //}*/

//public LáncoltLista<ILejátszható> Valogatas(LáncoltLista<ILejátszható> tartalom, string[] támogatott)
//       {
//           // LinkedList<ILejátszható> válogatott = new LinkedList<ILejátszható>();
//           LáncoltLista<ILejátszható> válogatott = new LáncoltLista<ILejátszható>();
//           ILejátszható[] t = tartalom.ToArray<ILejátszható>();
//           ILejátszható[] val = new ILejátszható[] { };
//           ListaElem<ILejátszható> aktuális = tartalom.Fej;
//           //string[] támogatottStilusok = new string[] { "Családias", "Mulatós", "Akció" };
//           int i = 0;    //támogatott indexe
//           int j = 0; //tartalom indexe
//           //while (i <= támogatott.Length - 1)
//           //{
//           //    if (val[j] == null && aktuális.Következő.Érték.Stílus == támogatott[i])
//           //    {
//           //        válogatott.ÚjJátékFelvétele(aktuális.Érték);
//           //    }
//           //    else
//           //    {
//           //        i++;
//           //        aktuális = tartalom.Fej;
//           //    }
//           //    if (aktuális.Következő == null)
//           //    {
//           //        aktuális = tartalom.Fej;
//           //        i++;
//           //    }
//           //    else if (aktuális.Érték.Stílus != támogatott[i])
//           //    {
//           //        aktuális = aktuális.Következő;
//           //    }
//           //    else
//           //    {
//           //        válogatott.ÚjJátékFelvétele(aktuális.Érték);
//           //        aktuális = aktuális.Következő;
//           //    }
//           //}
//           return null;
//       }
// ListaElem<ILejátszható> aktuális = tartalom.Fej;
//string[] támogatottStilusok = new string[] { "Családias", "Mulatós", "Akció" };
// int i = 0;    //támogatott indexe
// lista l = new lista();
//l.Adatok.

//while (i <= támogatott.Length - 1)
//{                
//    if (aktuális.Következő == null)
//    {
//        aktuális = tartalom.Fej;
//        i++;
//    }
//    else if (aktuális.Érték.Stílus != támogatott[i])
//    {
//        aktuális = aktuális.Következő;
//    }
//    else
//    {
//        válogatott.ÚjJátékFelvétele(aktuális.Érték);
//        aktuális = aktuális.Következő;
//    }
//}
//     return válogatott;      

////