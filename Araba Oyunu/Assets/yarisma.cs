using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yarisma : MonoBehaviour {

    public Text soruismi, cevapa, cevapb, cevapc, cevapd;
    questiontypes sr;

    public List<bool> sorulanlar;
    public int cevap;
    private int count;

    
	
	void Start () {
        if (PlayerPrefs.GetInt("deger") == 0)
        {
            
            PlayerPrefs.SetInt("deger", 1);
            count = 0;
            
        }
        else
        {
           
            
        }
        
        
        sr = GetComponent<questiontypes>();
        for (int i = 0; i < 5; i++)
        {
            sorulanlar.Add(false);

        }
        soruEkle();

	}
	
	
	void Update () {
		
	}
    public void soruEkle()
    {
        for(int i=0; i<5; i++)
        {
            if (sorulanlar[i] == false)
            {
                int sorusayi = Random.Range(0, 5);
                print(sorusayi);
                if (sorulanlar[sorusayi] == false)
                {
                    
                    sorulanlar[sorusayi] = true;
                    soruismi.text = "SORU: " + sr.sorucesitleri[sorusayi].soruismi;
                    cevapa.text = sr.sorucesitleri[sorusayi].cevapa;
                    cevapb.text = sr.sorucesitleri[sorusayi].cevapb;
                    cevapc.text = sr.sorucesitleri[sorusayi].cevapc;
                    cevapd.text = sr.sorucesitleri[sorusayi].cevapd;
                    cevap = sr.sorucesitleri[sorusayi].cevap;

                }
                else
                {
                    soruEkle();
                }
                break;
            }
            if (i == 4)
            {
                PlayerPrefs.SetInt("sayac", count);
                Application.LoadLevel(1);

            }
        }
        
       

    }
    public void cevapver(int deger)
    {
        if (deger == cevap)
        {
            soruEkle();
            count = count + 1;
        }
        else
        {
            PlayerPrefs.SetInt("sayac", count);
            Debug.Log("Yanlış cevap verdiniz!");
            Application.LoadLevel(1);

        }
    }
}
