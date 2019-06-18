using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnMore : MonoBehaviour
{
    public GameObject frnt,mid,bck,head,ob1;
    void OnMouseDown()
    {
        frnt.SetActive(false);
        mid.SetActive(false);
        bck.SetActive(false);
        head.SetActive(false);
        gameObject.SetActive(false);
        ob1.SetActive(true);
    }
}
