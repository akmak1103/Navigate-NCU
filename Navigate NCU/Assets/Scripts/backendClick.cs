using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backendClick : MonoBehaviour
{
    public GameObject front,middle,button,layers;
    void OnMouseDown()
    {
        middle.SetActive(false);
        front.SetActive(false);
        button.SetActive(true);
        Animator anim = layers.GetComponent<Animator>();
        anim.SetInteger("backClick",1);
    }
}
