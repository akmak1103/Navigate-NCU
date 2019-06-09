using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickLayers : MonoBehaviour
{
    public Animator anim;
    Collider click;
    void OnMouseDown()
    {
        anim.SetInteger("firstClick",1);
        click = GetComponent<BoxCollider>();
        click.enabled=false;
    }
}
