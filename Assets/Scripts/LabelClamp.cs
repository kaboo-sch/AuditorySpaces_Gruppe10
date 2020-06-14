using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelClamp : MonoBehaviour
{

    public Text LabelLevel;

    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        LabelLevel.transform.position = namePos;
    }
}
