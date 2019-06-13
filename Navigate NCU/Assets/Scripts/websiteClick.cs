using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class websiteClick : MonoBehaviour
{
    public GameObject code,db;
    public GameObject layers;
    void OnMouseDown()
    {
        code.SetActive(true);
        db.SetActive(true);
        Animator anim = layers.GetComponent<Animator>();
        anim.SetInteger("click",1)
;    }
}
