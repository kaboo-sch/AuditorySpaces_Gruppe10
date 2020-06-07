using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceThrust : MonoBehaviour
{

    public float SpaceSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, SpaceSpeed * Time.deltaTime);
    }
}
