using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class question  
{
    public string soruismi, cevapa, cevapb, cevapc, cevapd;
    public int cevap;


	
    public question(string soru,string cevap1, string cevap2, string cevap3, string cevap4,int cvp)
    {
        soruismi = soru;
        cevapa = cevap1;
        cevapb = cevap2;
        cevapc = cevap3;
        cevapd = cevap4;
        cevap = cvp;




    }
	
}
