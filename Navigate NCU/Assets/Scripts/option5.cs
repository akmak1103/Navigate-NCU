using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option5 : MonoBehaviour
{
    public GameObject img,arrow,back;
    public GameObject menu;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        back.SetActive(true);
        img.SetActive(true);
        arrow.SetActive(true);
        menu.SetActive(false);
    }
}
