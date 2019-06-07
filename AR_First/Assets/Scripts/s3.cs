using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s3 : MonoBehaviour
{
    public Animator s3ClickAnim;
    public GameObject g1,g2;
    public GameObject s3D,back;
    public GameObject facRoomText;

    void OnMouseDown()
    {
        s3ClickAnim.SetInteger("sphere",3);
        facRoomText.SetActive(false);
        s3D.SetActive(true);
        back.SetActive(true);
    }
}
