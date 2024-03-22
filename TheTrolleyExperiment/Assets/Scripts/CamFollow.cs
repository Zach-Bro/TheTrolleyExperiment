using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform cameraPos;
    public Light flashLight;
    public AudioClip LightOn, LightOff;
    public AudioSource Source;
    bool isOn = false;
    public bool isLight;

    private void Update()
    {
            transform.position = cameraPos.position;

        if (isLight)
        {
            if (!isOn && Input.GetKeyDown(KeyCode.F))
            {
                isOn = true;
                flashLight.enabled = true;
                Source.PlayOneShot(LightOn);
                
            }
            else if (isOn && Input.GetKeyDown(KeyCode.F))
            {
                isOn = false;
                flashLight.enabled = false;
                Source.PlayOneShot(LightOff);
            }
        }
        
    }

}
