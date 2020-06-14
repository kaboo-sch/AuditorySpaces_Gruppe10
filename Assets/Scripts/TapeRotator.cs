using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeRotator : MonoBehaviour
{

    public float tapeRotateSpeed;
    public bool TapeOn = false;
    // Update is called once per frame
    void Update()
    {
        if (TapeOn == true)
            transform.Rotate(Vector3.forward, tapeRotateSpeed * Time.deltaTime);
    }

    public void TapeOnPlz(){
        TapeOn = true;
    }
}
