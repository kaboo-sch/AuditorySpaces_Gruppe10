using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangebyCoordinate : MonoBehaviour
{
    public GameObject playerObj;
    // Update is called once per frame
    void Update()
    {
        if (playerObj.transform.position.x <= -24){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
