using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsOpener : MonoBehaviour
{
    public GameObject Image;

    public void OpenImage()
    {
        if(Image != null)
        {
            bool isActive = Image.activeSelf;

            Image.SetActive(!isActive);
        }
    }
}
