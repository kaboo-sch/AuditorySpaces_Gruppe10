using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public int speed = 5;
    bool stepsFired = false;
    public GameObject PlayerObj;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;  //Position des Players += Kamerablickrichtung
            startStepSound();
            stepsFired = true;
        }

        else if (stepsFired == true)
        {
            stopStepSound();
        }
    }

    public void startStepSound()
    {
        if (stepsFired == false)
        {
            PlayerObj.GetComponent<AudioSource>().Play();
        }
    } 

    public void stopStepSound()
    {
        PlayerObj.GetComponent<AudioSource>().Stop();
        stepsFired = false;
        //Debug.Log("Stop Funktion");
    }
}
