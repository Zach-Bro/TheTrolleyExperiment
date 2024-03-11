using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHitButton : MonoBehaviour
{
    public Camera cam;
    public LayerMask WhatIsButton;

    private void Update()
    {
        RaycastHit hit;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 1f, WhatIsButton) && Input.GetMouseButtonDown(0))
        {
            Transform objectHit = hit.transform;
            objectHit.gameObject.SetActive(false);
        }
    }

    
}
