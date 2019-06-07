using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour
{
    //public Animator mainMenu;
    public GameObject leftArrow,rightArrow,stArrow;
    public GameObject menu,image;
    public void back()
    {
        print(1);
        if (leftArrow.activeSelf)
        {
            Debug.Log("BackButton Pressed");
            leftArrow.SetActive(false); 
        }

        if (rightArrow.activeSelf)
        {
            Debug.Log("BackButton Pressed");
            rightArrow.SetActive(false); 
        }

        if (stArrow.activeSelf)
        {
            Debug.Log("BackButton Pressed");
            stArrow.SetActive(false); 
        }
        image.SetActive(false);
        menu.SetActive(true);
        gameObject.SetActive(false);
    }
}
