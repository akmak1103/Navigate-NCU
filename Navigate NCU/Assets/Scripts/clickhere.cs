using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickhere : MonoBehaviour
{
    public GameObject code;
    void OnMouseDown()
    {
        code.SetActive(true);
    }
}
