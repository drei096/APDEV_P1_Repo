using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colormodifier : MonoBehaviour
{
    public GameObject colorPanel;
    public Slider red;
    public Slider green;
    public Slider blue;

    // Start is called before the first frame update
    public void OnEdit()
    {
        Color color = colorPanel.GetComponent<Image>().color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        colorPanel.GetComponent<Image>().color = color;

    }
}
