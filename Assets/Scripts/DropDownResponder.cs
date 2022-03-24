using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownResponder : MonoBehaviour
{
    public Text choice;
    public Text output;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = output.text;
    }

    // Update is called once per frame
    public void OnEdit()
    {
        this.GetComponent<Text>().text = choice.text;
    }
}
