using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{

    public AudioSource AudioTrigger;
    public GameObject myPlayer;

    void Update()
    {
        if(!AudioTrigger.isPlaying){
            SceneManager.LoadScene("Menu");
        }
    }
}
