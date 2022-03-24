using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuSwitcher : MonoBehaviour
{
    public GameObject landscapePanel;
    public GameObject portraitPanel;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            this.landscapePanel.SetActive(true);
            this.portraitPanel.SetActive(false);
        }
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            this.landscapePanel.SetActive(false);
            this.portraitPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            this.landscapePanel.SetActive(true);
            this.portraitPanel.SetActive(false);
        }
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            this.landscapePanel.SetActive(false);
            this.portraitPanel.SetActive(true);
        }
    }
}
