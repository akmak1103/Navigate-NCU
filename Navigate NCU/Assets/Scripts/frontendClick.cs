using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontendClick : MonoBehaviour
{
    public GameObject middle,back,button;
    void OnMouseDown()
    {
        middle.SetActive(false);
        back.SetActive(false);
        button.SetActive(true);
    }
}
