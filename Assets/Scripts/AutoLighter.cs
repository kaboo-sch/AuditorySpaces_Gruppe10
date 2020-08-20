using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLighter : MonoBehaviour
{

    private bool lighters;
    public GameObject carMat;
    private Rigidbody carBody;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        lighters = false;
        carBody = car.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lighters){
            carMat.GetComponent<Light>().enabled = true;
        }

        else {
            carMat.GetComponent<Light>().enabled = false;
        }
    }

    public void lightsOn(){
        lighters = true;
        carBody.AddForce(transform.up * 5000 * Time.deltaTime);
    }

    public void lightsOff(){
        lighters = false;
    }
}
