using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromTunnelToSpaceship : MonoBehaviour
{

    bool WheelHit = false;
    public GameObject myPlayer; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(WheelHit)
        {
            transform.Rotate(Vector3.right, 40f * Time.deltaTime);

            if (myPlayer.GetComponent<GazeFiller>().imgGaze.fillAmount >= 1)
            {
                Debug.Log("Gaze Full");
                SceneManager.LoadScene("SpaceStudio");
            }
        }


    }

    public void WheelIsHit()
    {
        WheelHit = true;

    }

    public void WheelIsUnhit()
    {
        WheelHit = false;
    }
}
