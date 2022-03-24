using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitButton : MonoBehaviour,IPointerDownHandler
{
    private void Awake()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Application.Quit();
    }

    public void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null) //if the button is touched
                {
                    Application.Quit();
                }
            }
        }
    }
}
