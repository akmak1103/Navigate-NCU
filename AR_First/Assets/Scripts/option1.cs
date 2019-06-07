using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option1 : MonoBehaviour
{
    public GameObject img1,arrow,back;
    public GameObject menu;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        img1.SetActive(true);
        arrow.SetActive(true);
        back.SetActive(true);
        menu.SetActive(false);
    }
}
