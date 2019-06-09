using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public GameObject front;
    public GameObject mid;
    public GameObject backend;
    public GameObject layers;

    void OnMouseDown()
    {
        Animator anim = layers.GetComponent<Animator>();
        if (front.activeSelf)
        {
            mid.SetActive(true);
            backend.SetActive(true);
        }
        if (mid.activeSelf)
        {
            front.SetActive(true);
            backend.SetActive(true);
            anim.SetInteger("midClick",0);
        }
        if (backend.activeSelf)
        {
            mid.SetActive(true);
            front.SetActive(true);
            anim.SetInteger("backClick",0);
        }
        gameObject.SetActive(false);
    }
}
