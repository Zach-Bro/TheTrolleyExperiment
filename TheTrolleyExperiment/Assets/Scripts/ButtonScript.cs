using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public float Whichbutton;
    public GameObject TalkieWalkie;
    public GameManager gameManager;
    public void ButtonPressed()
    {
        if (Whichbutton == -1)
        {
            gameManager.startRadioWelcome();
           TalkieWalkie.SetActive(false);
        }


        //Kill only one person (1)
        if (Whichbutton == 0)
        {
            Debug.Log("oneperson has died");
        }

        //Kill five people (1)
        if (Whichbutton == 1)
        {
            gameObject.GetComponent<Animator>().SetTrigger("lmao");
            Debug.Log("5 people have died");
        }

        //Kill only your best friend (2)
        if (Whichbutton == 2)
        {

        }

        //Kill five strangers (2)
        if (Whichbutton == 3)
        {

        }

        //
        if (Whichbutton == 4)
        {

        }

        //
        if (Whichbutton == 5)
        {

        }

        //
        if (Whichbutton == 6)
        {

        }

        //
        if (Whichbutton == 7)
        {

        }
    }
}
