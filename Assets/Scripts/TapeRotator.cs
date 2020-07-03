using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeRotator : MonoBehaviour
{

    public float tapeRotateSpeed;
    public GameObject myPlayer;
    bool TriggerActive = false;
    bool hittoturn = false;


    // Update is called once per frame
    void Update()
    {

        if (TriggerActive)
        {
            /*
             * Wenn über den Trigger der Boolean auf true gesetzt wurde,
             * wird hier gecheckt, ob ob der Kreis voll ist. Falls ja, wird die 
             * Scene geladen. Der Name der Scene muss auf dem Objekt eingetragen werden.
             */

            if (myPlayer.GetComponent<GazeFiller>().imgGaze.fillAmount >= 1)
            {
                hittoturn = true;
            }

            if (hittoturn)
            {
                transform.Rotate(Vector3.forward, tapeRotateSpeed * Time.deltaTime);
            }
        }
    }

    public void setCheckActive()
    {
        TriggerActive = true;
    }
}
