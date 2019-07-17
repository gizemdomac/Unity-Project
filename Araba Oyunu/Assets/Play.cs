using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
    araba nesne1 = new araba();
    public void playgame()
    {
        Application.LoadLevel(1);
        nesne1.hiz = 100;

    }
	
}
