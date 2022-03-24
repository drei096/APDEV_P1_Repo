using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupResponder : MonoBehaviour
{
    [SerializeField] GameObject togglegroup;
    [SerializeField] Text choice;

    public void changeToggleGroupText()
    {
        ToggleGroup toggleGroup = togglegroup.GetComponent<ToggleGroup>();
        Toggle[] toggles = toggleGroup.GetComponentsInChildren<Toggle>();
        foreach (var item in toggles)
        {
            if (item.isOn)
            {
                choice.text = item.GetComponentInChildren<Text>().text;
            }
        }
    }
}
