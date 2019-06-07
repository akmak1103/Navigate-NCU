using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S1 : MonoBehaviour
{
    public Animator s1ClickAnim;
    public GameObject g2,g3;
    public GameObject s1D, back;
    public GameObject deanOfficeText;
    
    void OnMouseDown()
    {
        s1ClickAnim.SetInteger("sphere",1);
        deanOfficeText.SetActive(false);
        s1D.SetActive(true);
        back.SetActive(true);
    }
}
