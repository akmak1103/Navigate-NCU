using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour
{
    public GameObject ironman,message;
    public GameObject menu;
    public GameObject panView;
    void OnMouseDown()
    {
        gameObject.SetActive(false);
        //ironman.SetActive(true);
        //message.SetActive(true);
        menu.SetActive(true);
        //panView.SetActive(true);
    }
}
