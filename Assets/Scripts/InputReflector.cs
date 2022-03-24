using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputReflector : MonoBehaviour
{
    public Text output;
    public Text input;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = output.text;
    }
    
    public void OnEdit()
    {
        this.GetComponent<Text>().text = input.text;
    }
}
