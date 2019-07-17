using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class araba : MonoBehaviour {
    public WheelCollider onsol, onsag, arkasol, arkasag;
    public GameObject car;
    public float hiz, donmehizi;
    private float x_koordinat,y_koordinat,z_koordinat;
    public Text benzin;
    public int benzinlitre,deger,counter,toplam;
    private float aradeger_position;

  
	
	void Start () {
        
        if (PlayerPrefs.GetInt("deger") == 1)
        {
            car.transform.position = new Vector3(PlayerPrefs.GetFloat("x_koor"), PlayerPrefs.GetFloat("y_koor"), PlayerPrefs.GetFloat("z_koor"));
            PlayerPrefs.SetInt("deger", 0);
            toplam = PlayerPrefs.GetInt("benzindegeri") + (PlayerPrefs.GetInt("sayac") * 10);
            benzinlitre = toplam;
            benzin.text = toplam.ToString() + " lt";
            aradeger_position = PlayerPrefs.GetFloat("x_koor") - 100;

            
        
        }
        else
        {
            aradeger_position = 600;
            PlayerPrefs.SetInt("benzindegeri", 100);
            benzinlitre = 100;
            benzin.text = benzinlitre.ToString()+" lt";
            car.transform.position = new Vector3(700, -10, -9);
            PlayerPrefs.SetInt("deger", 0);
        }

	}
  
	void Update () {
        arkasol.motorTorque = hiz * Input.GetAxis("Vertical");
        arkasag.motorTorque = hiz * Input.GetAxis("Vertical");
        onsol.steerAngle = donmehizi * Input.GetAxis("Horizontal");
        onsag.steerAngle = donmehizi * Input.GetAxis("Horizontal");

        hiz = PlayerPrefs.GetInt("hiz");
        x_koordinat = car.transform.position.x;
        y_koordinat = car.transform.position.y;
        z_koordinat = car.transform.position.z;
        PlayerPrefs.SetFloat("x_koor", x_koordinat);
        PlayerPrefs.SetFloat("y_koor", y_koordinat);
        PlayerPrefs.SetFloat("z_koor", z_koordinat);

        if (x_koordinat < aradeger_position && x_koordinat > (aradeger_position - 5))
        {
            benzinlitre = benzinlitre - 10;
            aradeger_position = aradeger_position - 100;
        }
        benzin.text = benzinlitre.ToString() + " lt";
        PlayerPrefs.SetInt("benzindegeri", benzinlitre);


        if (x_koordinat < (-600))
            Application.LoadLevel(4);

        if (benzinlitre <= 0)
            Application.LoadLevel(2);

        if (Input.GetKey(KeyCode.R))
        {
        
            Application.LoadLevel(0);
        }
      
	}
}
