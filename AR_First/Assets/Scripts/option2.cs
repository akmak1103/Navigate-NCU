using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option2 : MonoBehaviour
{
    public GameObject img2,arrow,back;
    public  GameObject menu;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        back.SetActive(true);
        img2.SetActive(true);
        arrow.SetActive(true);
        menu.SetActive(false);
    }
}
