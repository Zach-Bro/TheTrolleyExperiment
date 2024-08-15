using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHitButton : MonoBehaviour
{
    public Camera cam;
    public LayerMask WhatIsButton;
    public GameObject lastButton;

    private void Update()
    {
        RaycastHit hit;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1f, WhatIsButton) && Input.GetMouseButtonDown(0))
        {
            Transform objectHit = hit.transform;
            objectHit.GetComponent<ButtonScript>().ButtonPressed();
            objectHit.gameObject.layer = LayerMask.NameToLayer("Default");

        }
        else if (Physics.Raycast(ray, out hit, 1f, WhatIsButton))
        {
            Transform objectHit = hit.transform;
            lastButton = objectHit.gameObject;
            objectHit.GetComponent<Outline>().enabled = true;
        }
        else if (lastButton != null)
        {
            lastButton.GetComponent<Outline>().enabled = false;
        }
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }

    
}
