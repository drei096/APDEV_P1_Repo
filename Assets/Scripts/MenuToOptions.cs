using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuToOptions : MonoBehaviour
{
    [SerializeField] private GameObject placeholderB1; //options button
    [SerializeField] private GameObject placeholderB2; //title button
    [SerializeField] private GameObject placeholderB3; //start button
    [SerializeField] private GameObject placeholderB4; //exit button
    [SerializeField] private GameObject placeholderB5; //back button
    [SerializeField] private Button options;
    [SerializeField] private Button title;
    [SerializeField] private GameObject placeholder1; //options panel
    [SerializeField] private GameObject placeholder3; //landscape panel
    [SerializeField] private GameObject placeholder4; //portrait panel


    // Start is called before the first frame update
    void Start()
    {
        this.placeholderB1.SetActive(true);
        this.placeholderB2.SetActive(true);
        this.placeholder1.SetActive(false); //options panel
        

        Button btn = options.GetComponent<Button>();
        btn.onClick.AddListener(OnStartOptions);

        Button btn2 = title.GetComponent<Button>();
        btn2.onClick.AddListener(OnBackTitle);
    }

    public void OnStartOptions()
    {

        this.placeholder1.SetActive(true);
        this.placeholder3.SetActive(false);
        this.placeholder4.SetActive(false);

        this.placeholderB1.SetActive(false);
        this.placeholderB2.SetActive(false);
        this.placeholderB5.SetActive(true);
    }

    public void OnBackTitle()
    {

        this.placeholder1.SetActive(false);
        this.placeholder3.SetActive(false);
        this.placeholder4.SetActive(false);


        this.placeholderB1.SetActive(false);
        this.placeholderB2.SetActive(false);

        this.placeholderB3.SetActive(true);
        this.placeholderB4.SetActive(true);
    }

}
