/*
This script is used for toggling on a UI Text component for a certain duration of time.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedText : MonoBehaviour
{
    public TMP_Text ChosenText;
    public float Duration = 1f;
    public bool shown = false;
    
    void Start()
    {
        ChosenText.gameObject.SetActive(false);
    }

    void OnCollisionEnter()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        if(shown==false){
        ChosenText.gameObject.SetActive(true);
        yield return new WaitForSeconds(Duration);
        shown = true;
        ChosenText.gameObject.SetActive(false);
        }
        
    }
}
