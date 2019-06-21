using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_Nav : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("exit clicked");
        Application.Quit();
    }
}
