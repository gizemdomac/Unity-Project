using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saat : MonoBehaviour {

    public float saniye, dakika, saat;
    public Text saatyazi;
	void Start () {

        saat = 0;
        dakika = 3;
        saniye = 15;

        if (PlayerPrefs.GetInt("deger") == 1)
        {
            
            saat = PlayerPrefs.GetFloat("saat");
            dakika = PlayerPrefs.GetFloat("dakika");
            saniye = PlayerPrefs.GetFloat("saniye");
          
        }
        else
        {
            saat = 0;
            dakika = 3;
            saniye = 15;
		
            PlayerPrefs.SetInt("deger", 0);
        }
       
	}
	
	void Update () {
        
        saatyazi.text = "" + saat.ToString("00") + ":" + dakika.ToString("00") + ":" + saniye.ToString("00");
        saniye -= Time.deltaTime;
        if (saat <= 0 && dakika <= 0 && saniye <= 0)
        {
         
            Application.LoadLevel(2);
        }
        if (saniye <= 0)
        {
            dakika -= 1;
            saniye = 59;
        }
        if(dakika<=0&&saniye<=0)
        {
            saat -= 1;
            dakika = 59;
            saniye = 59;
        }
    
        PlayerPrefs.SetFloat("saat", saat);
        PlayerPrefs.SetFloat("dakika", dakika);
        PlayerPrefs.SetFloat("saniye", saniye);
      
	}
}
