using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Math : MonoBehaviour
{
    public Text sahnedekiText, ilksayi, ikincisayi, islem, cevap, sonuc;
    public UnityEngine.UI.InputField sonucInput;

    int sayi2, sayi3, islemisareti, sayi1, islemsonucu;



    void Start()
    {
        Yenisoru();
    }


    void Update()
    {
    }


    public void Cevapkontrol()
    {
        if (int.Parse(cevap.text) == islemsonucu)
        {
            sonuc.text = "Doğru";
        }

        else
        {
            sonuc.text = "!!YANLIŞ!!";
        }

    }

    public void Yenisoru()
    {

        sonuc.text = "";
        sonucInput.text = "";

        sayi1 = sayi2*sayi3;
        sayi2 = Random.Range(1, 10);
        sayi3 = Random.Range(1, 10);
        
        islemisareti = Random.Range(1, 5);
        switch (islemisareti)
        {
            case 1:
                islem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "x";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                islemsonucu = sayi1 / sayi2;
                break;

          

        }

        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";


    }

}
