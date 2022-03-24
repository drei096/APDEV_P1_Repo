using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsBack : MonoBehaviour
{
    [SerializeField] private GameObject placeholderB1; //options button
    [SerializeField] private GameObject placeholderB2; //title button
    [SerializeField] private GameObject placeholderB3; //back button
    [SerializeField] private GameObject placeholderB4; //options button portrait
    [SerializeField] private GameObject placeholderB5; //title button portrait
    [SerializeField] private Button back;
    [SerializeField] private GameObject placeholder1; //options panel
    [SerializeField] private GameObject placeholder3; //landscape panel
    [SerializeField] private GameObject placeholder4; //portrait panel

    void Start()
    {
        this.placeholderB1.SetActive(false);
        this.placeholderB2.SetActive(false);
        this.placeholderB3.SetActive(true);
        this.placeholder1.SetActive(true); //options panel
        this.placeholder3.SetActive(false); //landscape panel
        this.placeholder4.SetActive(false); //portrait panel

        Button btn = back.GetComponent<Button>();
        btn.onClick.AddListener(OnBackMenu);

    }

    public void OnBackMenu()
    {
        this.placeholderB3.SetActive(false);
        

        this.placeholder1.SetActive(false);

        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            this.placeholderB2.SetActive(true);
            this.placeholderB1.SetActive(true);

            this.placeholder3.SetActive(true);
            this.placeholder4.SetActive(false);
        }

        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            this.placeholderB4.SetActive(true);
            this.placeholderB5.SetActive(true);

            this.placeholder3.SetActive(false);
            this.placeholder4.SetActive(true);
        }
    }
}
