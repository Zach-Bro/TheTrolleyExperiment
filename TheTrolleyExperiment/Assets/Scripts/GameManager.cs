using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioClip ObjectPickUp, PhonePickUp, PhoneUnpickUp, BuzzSound, Welcome1;
    public AudioSource source; //It's on the player

    public void startRadioWelcome()
    {
        StartCoroutine(RadioWelcome());
    }

    public IEnumerator RadioWelcome()
    {
        source.PlayOneShot(ObjectPickUp);
        yield return new WaitForSeconds(5f);
        source.PlayOneShot(PhonePickUp);
        yield return new WaitForSeconds(0.5f);
        source.PlayOneShot(Welcome1);
        yield return new WaitForSeconds(2f);
        source.Stop();
        source.PlayOneShot(BuzzSound);
        yield return new WaitForSeconds(0.368f);
        source.clip = Welcome1;
        source.Play();
        source.time = 2.8f;




        StopCoroutine(RadioWelcome());
    }

    
}
