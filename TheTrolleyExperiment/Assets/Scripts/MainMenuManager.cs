using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public float rotationSpeed = 90f;
    private Quaternion targetRotation;
    [SerializeField]private bool isRotating = false;
    [SerializeField]private bool OnOptions = false;
    public GameObject cameraOBJ;

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionsButton()
    {
        if (!isRotating)
        {
            StartRotation();
        }

    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Get outta here");
    }


    private void StartRotation()
    {
        if (!OnOptions && !isRotating)
        {
            targetRotation = transform.rotation * Quaternion.Euler(0, 90, 0);
            isRotating = true;
            OnOptions = true;
        }
        if (OnOptions && !isRotating)
        {
            targetRotation = transform.rotation * Quaternion.Euler(90, 0, -90);
            isRotating = true;
            OnOptions = false;
        }   
    }

    private void Update()
    {
        if (isRotating)
        {
            cameraOBJ.transform.rotation = Quaternion.RotateTowards(cameraOBJ.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if we've reached the target rotation
            if (cameraOBJ.transform.rotation == targetRotation)
            {
                isRotating = false;
            }
        }


    }
}
