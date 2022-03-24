using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonReplicator : MonoBehaviour
{
    [SerializeField] GameObject buttonToClick;
    [SerializeField] private GameObject buttonCopy;

    private void Awake()
    {

    }

    public void OnClick()
    {
        buttonCopy = GameObject.Instantiate(buttonCopy);
        buttonCopy.transform.parent = buttonToClick.transform;
        buttonCopy.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }

    
}
