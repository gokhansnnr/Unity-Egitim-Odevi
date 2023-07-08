using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumSonuOdevi : MonoBehaviour
{

    //Belirlenen say�lar aras�nda ikiye, ��e, d�rde ve be�e b�l�nebilen say�lar� bulan kod.

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
        print("T�m Liste: " + tumListeString);
        print("�kiye B�l�nenler: " + ikiyeBolunenString);
        print("��e B�l�nenler: " + uceBolunenString);
        print("D�rde B�l�nenler: " + dordeBolunenString);
        print("Be�e B�l�nenler: " + beseBolunenString);
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
