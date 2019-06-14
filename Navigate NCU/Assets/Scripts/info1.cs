using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info1 : MonoBehaviour
{
    public GameObject text,info;
    void OnMouseDown()
    {
        info.SetActive(true);
        text.SetActive(false);
    }
}
