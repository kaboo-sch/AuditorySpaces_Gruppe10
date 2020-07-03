using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateWalkingScript : MonoBehaviour
{

    public GameObject Player;
    public AudioSource TriggerSource;
    public Text InstrText;
    public string TextInput;
    bool textChanged = false;

    // Update is called once per frame
    void Update()
    {
        if (!TriggerSource.isPlaying)
        {
            Player.GetComponent<WalkingScript>().enabled = true;

            if (textChanged == false)
            {
                TextChange();
            }
            textChanged = true;

        }
    }

    void TextChange()
    {
        InstrText.text = TextInput;
    }
   
}
