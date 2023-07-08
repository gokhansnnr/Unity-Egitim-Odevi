using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumSonuOdevi : MonoBehaviour
{

    //Belirlenen sayýlar arasýnda ikiye, üçe, dörde ve beþe bölünebilen sayýlarý bulan kod.

    public int ilksayi;
    public int ikincisayi;

    void bolenleriBul(int ilk, int ikinci)
    {
        ArrayList tumListe = new ArrayList();
        string tumListeString = "";
        string ikiyeBolunenString = "";
        string uceBolunenString = "";
        string dordeBolunenString = "";
        string beseBolunenString = "";
        for (int i = ilk; i<=ikinci; i++)
        {
            tumListe.Add(i);
            tumListeString += " - " + i;

            if (i % 2 == 0)
            {
                ikiyeBolunenString += " - " + i;
            }
            if (i % 3 == 0)
            {
                uceBolunenString += " - " + i;
            }
            if (i % 4 == 0)
            {
                dordeBolunenString += " - " + i;
            }
            if (i % 5 == 0)
            {
                beseBolunenString += " - " + i;
            }
        }

        print("-----------------------------");
        print("Tüm Liste: " + tumListeString);
        print("Ýkiye Bölünenler: " + ikiyeBolunenString);
        print("Üçe Bölünenler: " + uceBolunenString);
        print("Dörde Bölünenler: " + dordeBolunenString);
        print("Beþe Bölünenler: " + beseBolunenString);
        print("-----------------------------");

    }


    void Start()
    {
        ilksayi = 20;
        ikincisayi = 44;
    }

    void Update()
    {
        bolenleriBul(ilksayi, ikincisayi);
    }
}
