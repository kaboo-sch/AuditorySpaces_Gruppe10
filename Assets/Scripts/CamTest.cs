using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTest : MonoBehaviour
{

    public float speedCam = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speedCam*Time.deltaTime);
    }
}
