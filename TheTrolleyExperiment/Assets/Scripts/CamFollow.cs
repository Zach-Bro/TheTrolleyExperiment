using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class CamFollow : MonoBehaviour
{
    public Transform cameraPos;
    public Light flashLight;
    public AudioClip LightOn, LightOff;
    public AudioSource Source;
    public GameObject LightTutoTxt;
    public MotionBlur MotionBlur;
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
                LightTutoTxt.SetActive(false);
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

        if(PlayerPrefs.GetInt("MotBlu") == 1)
        {
            MotionBlur.active = true;
        }
        else if(PlayerPrefs.GetInt("MotBlu") == 0)
        {
            MotionBlur.active = false;
        }
        
    }

}
