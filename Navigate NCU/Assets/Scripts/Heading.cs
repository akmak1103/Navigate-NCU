using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heading : MonoBehaviour
{
    public GameObject c1,c2,c3,steps;
    void OnMouseDown()
    {
        c1.SetActive(true);
        c2.SetActive(true);
        c3.SetActive(true);
        steps.SetActive(true);
    }
}
