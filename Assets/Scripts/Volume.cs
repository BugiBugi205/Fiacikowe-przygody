using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public void Value(float value)
    {
        GetComponent<Text>().text = (value*100).ToString();
    }
}
