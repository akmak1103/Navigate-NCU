using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleClick : MonoBehaviour
{
    public GameObject front,back,button;
    public GameObject layers;
    void OnMouseDown()
    {
        back.SetActive(false);
        front.SetActive(false);
        button.SetActive(true);
        Animator anim = layers.GetComponent<Animator>();
        anim.SetInteger("midClick",1);
    }
}
