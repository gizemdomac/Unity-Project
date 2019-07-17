using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyna : MonoBehaviour {
  
    public int hiz;

    public void oyunbasla()
    {
        PlayerPrefs.SetInt("hiz", 100);
        hiz = 100;
        Application.LoadLevel(1);
    }
}
