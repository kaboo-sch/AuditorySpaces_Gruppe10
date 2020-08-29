using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioPlay : MonoBehaviour
{

    public GameObject myPlayer;
    public GameObject myCar;

    public AudioSource SinginInTheCar;
    public AudioSource TapeDeck;
    public AudioSource AudioTrigger;

    public Text LevelLabel;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = myCar.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!AudioTrigger.isPlaying)
        {
            LevelLabel.text = "Schalte das Radio ein";
        }

        if (myPlayer.GetComponent<GazeFiller>().imgGaze.fillAmount >= 1)
        {
            TapeDeck.Play();
            SinginInTheCar.Play();

            animator.SetBool("isAnimating", true);
        }
    }
}
