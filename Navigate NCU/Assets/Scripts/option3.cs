using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option3 : MonoBehaviour
{
    public GameObject img3,arrow,back;
    public  GameObject menu;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        img3.SetActive(true);
        arrow.SetActive(true);
        back.SetActive(true);
        menu.SetActive(false);
    }
}
