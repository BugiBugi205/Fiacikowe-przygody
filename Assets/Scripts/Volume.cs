using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public void ValueDisplay(float value)
    {
        GetComponent<Text>().text = (Mathf.Floor(value*100)).ToString();
    }
}
