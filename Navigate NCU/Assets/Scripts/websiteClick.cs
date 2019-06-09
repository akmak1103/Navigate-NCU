using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class websiteClick : MonoBehaviour
{
    public GameObject layers;
    void OnMouseDown()
    {
        Debug.Log("clicked");
        gameObject.SetActive(false);
        layers.SetActive(true);
    }
}
