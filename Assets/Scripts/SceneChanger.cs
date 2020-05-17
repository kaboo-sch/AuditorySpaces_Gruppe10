using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject myPlayer;
    bool TriggerActive = false;
    public string SceneToLoad;


    private void Update()
    {
        if(TriggerActive)
        {
            /*
             * Wenn über den Trigger der Boolean auf true gesetzt wurde,
             * wird hier gecheckt, ob ob der Kreis voll ist. Falls ja, wird die 
             * Scene geladen. Der Name der Scene muss auf dem Objekt eingetragen werden.
             */

            if (myPlayer.GetComponent<GazeFiller>().imgGaze.fillAmount >= 1)
            {
                Debug.Log("Gaze Full");
                SceneManager.LoadScene(SceneToLoad);
            }
        }

    }

    /*
     * Hier werden via Trigger auf dem Objekt die Werte true (PointerEnter) oder
     * false (PointerExit) gesetzt.
     */

    public void setCheckActive()
    {
        TriggerActive = true;
    }

    public void unsetCheckActive()
    {
        TriggerActive = false;
    }
}
