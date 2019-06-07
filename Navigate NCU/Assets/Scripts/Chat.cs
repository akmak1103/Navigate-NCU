using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : MonoBehaviour
{
    public GameObject ball;

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        ball.SetActive(true);
    }
}
