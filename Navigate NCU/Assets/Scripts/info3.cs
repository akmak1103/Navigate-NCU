using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info3 : MonoBehaviour
{
    public GameObject text,info,button,steps;
    void OnMouseDown()
    {
        info.SetActive(true);
        text.SetActive(false);
        button.SetActive(true);
        steps.SetActive(false);
    }
}
