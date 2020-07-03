using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tape_ForrestSound : MonoBehaviour
{

    public GameObject myPlayer;
    bool TriggerActive = false;
    public AudioSource[] ForrestAudio;
    public Text Instructor;

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
                Debug.Log("Gaze Full");
                ForrestAudio[0].Play();
                ForrestAudio[1].Play();
                TriggerActive = false;
                Instructor.text = "Erhöhe die Lautstärke und den Hall der Waldgeräusche, um in den Wald zu gelangen.";
            }
        }
    }

    public void setCheckActive()
    {
        TriggerActive = true;
    }

    public void unsetCheckActive()
    {
        TriggerActive = false;
    }
}
