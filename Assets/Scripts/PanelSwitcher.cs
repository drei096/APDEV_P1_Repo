using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject buttonToClick;
    public GameObject panelToEnable;
    public GameObject panelToEnable2;

    private void Awake()
    {

    }

    public void OnClickLandScape()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            if (buttonToClick.name == "StartButton")
            {
                buttonToClick.SetActive(false);
                GameObject.Find("ExitButton").SetActive(false);
                panelToEnable.SetActive(true);
            }
        }
        
    }

    public void OnClickPortrait()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            if (buttonToClick.name == "StartButton")
            {
                buttonToClick.SetActive(false);
                //GameObject.Find("ExitButton").SetActive(false);
                panelToEnable2.SetActive(true);
            }
        }
       
    }

    public void Update()
    {
        
    }
}
