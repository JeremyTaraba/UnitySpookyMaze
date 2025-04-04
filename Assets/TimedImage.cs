/*
This script is used for toggling on a UI Text component for a certain duration of time.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TimedImage : MonoBehaviour
{
    public RawImage ChosenImage;
    public float Duration = 1f;
    public bool shown = false;
    [SerializeField]
    private AudioSource audio;
    
    void Start()
    {
        ChosenImage.gameObject.SetActive(false);
    }

    void OnCollisionEnter()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        if(shown == false){
            shown = true;
            audio.Play();
            ChosenImage.gameObject.SetActive(true);
            yield return new WaitForSeconds(Duration);
            ChosenImage.gameObject.SetActive(false);
        }
        
    }
}
