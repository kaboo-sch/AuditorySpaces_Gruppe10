using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeRotator : MonoBehaviour
{

    public float tapeRotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, tapeRotateSpeed * Time.deltaTime);
    }
}
