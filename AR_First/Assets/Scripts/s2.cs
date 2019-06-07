using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s2 : MonoBehaviour
{
    public Animator s2ClickAnim;
    public GameObject g1,g3;
    public GameObject s2D,back;
    public GameObject commonRoomText;

    void OnMouseDown()
    {
        s2ClickAnim.SetInteger("sphere",2);
        commonRoomText.SetActive(false);
        s2D.SetActive(true);
        back.SetActive(true);
    }
}
