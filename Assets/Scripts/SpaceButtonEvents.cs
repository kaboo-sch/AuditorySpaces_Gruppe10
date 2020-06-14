using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceButtonEvents : MonoBehaviour
{
    public GameObject myObj;
    public GameObject Fader;
    public GameObject Monitor;

    public Text LevelLabel;

    private bool ButtonHit = false;
    private Material mat;
    private Light lit;
    public float maxLit = 0.5f;
    public float minLit = 0.2f;
    private Vector3 curPos;
    private Vector3 moveDir;

    void Start()
    {
        mat = myObj.GetComponent<Renderer>().material;
        lit = myObj.GetComponent<Light>();
    }
       
    void Update()
    {
        if (ButtonHit){
            //Debug.Log("Hit angekommen");
            mat.DisableKeyword("_EMISSION");
            lit.range = maxLit;

            Fader.transform.position = Vector3.Lerp(Fader.transform.position, curPos + moveDir, 0.1f);
        }
    }

    public void HitTheButton()
    {
        ButtonHit = true;

        if (myObj.name == "Cube.001")
        {
            //Fader.transform.Translate(-0.05f, 0, 0);
            curPos = Fader.transform.position;
            moveDir = new Vector3(-0.1f,0,0);
            Monitor.GetComponent<AudioSource>().reverbZoneMix += 0.15f;
            LevelLabel.text = "Reverb: " + "\n" + Mathf.Round(Monitor.GetComponent<AudioSource>().reverbZoneMix * 10000.0f) / 100.0 + "%";
        }
        else if (myObj.name == "Cube")
        {
            //Fader.transform.Translate(0.05f, 0, 0);
            curPos = Fader.transform.position;
            moveDir = new Vector3(0.1f, 0, 0);
            Monitor.GetComponent<AudioSource>().reverbZoneMix -= 0.15f;
            LevelLabel.text = "Reverb: " + Mathf.Round(Monitor.GetComponent<AudioSource>().reverbZoneMix * 10000.0f) / 100.0 + "%";
        }
    }

    public void UnHitTheButton(){
        ButtonHit = false;
        mat.EnableKeyword("_EMISSION");
        lit.range = minLit;
    }
}
