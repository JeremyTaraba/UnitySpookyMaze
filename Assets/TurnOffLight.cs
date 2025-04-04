using UnityEngine;

public class TurnOffLight : MonoBehaviour
{
    public GameObject light;
    private bool on = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && on == true){
            light.SetActive(false);
            on = false;
        }
        else if (Input.GetMouseButtonDown(0) && on == false){
            light.SetActive(true);
            on = true;
        }
    }
}
