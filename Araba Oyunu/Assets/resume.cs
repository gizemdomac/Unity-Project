using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume: MonoBehaviour
{
     public bool pause = false;

	// Use this for initialization
	void Start () {
        pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     public void onPause()
    {
        pause = !pause;
        if(!pause)
        {
            Time.timeScale = 1;

        }
        else if(pause)
        {
            Time.timeScale = 0;
        }

    }
}

