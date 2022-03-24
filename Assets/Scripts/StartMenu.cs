using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject placeholderB1;
    [SerializeField] private GameObject placeholderB2;
    [SerializeField] private GameObject placeholderB3; //options button
    [SerializeField] private GameObject placeholderB4; //title button
    [SerializeField] private GameObject placeholderB5; //options button portrait
    [SerializeField] private GameObject placeholderB6; //title button portrait
    [SerializeField] private Button start;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject placeholder1;
    [SerializeField] private GameObject placeholder2;
    [SerializeField] private GameObject placeholder3;
    public static DeviceOrientation orientation;

    // Start is called before the first frame update
    void Start()
    {
        this.placeholderB1.SetActive(true);
        this.placeholderB2.SetActive(true);
        this.placeholder1.SetActive(false); //landscape panel
        this.placeholder2.SetActive(false); //portrait panel
        this.placeholder3.SetActive(false); //options panel

        //Debug.Log(Input.deviceOrientation);

        Button btn = start.GetComponent<Button>();
        btn.onClick.AddListener(OnStartApp);
    }

    public void OnStartApp()
    {
      
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            this.placeholder1.SetActive(true);
            this.placeholder2.SetActive(false);

            this.placeholderB3.SetActive(true);
            this.placeholderB4.SetActive(true);
        }

        if(Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
           
            this.placeholder1.SetActive(false);
            this.placeholder2.SetActive(true);

            this.placeholderB5.SetActive(true);
            this.placeholderB6.SetActive(true);
        }

        

        this.placeholderB1.SetActive(false);
        this.placeholderB2.SetActive(false);
    }
    
}
