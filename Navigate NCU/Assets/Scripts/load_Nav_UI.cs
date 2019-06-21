using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_Nav_UI : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
