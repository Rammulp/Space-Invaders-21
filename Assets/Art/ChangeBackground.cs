using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackgroundOnClick : MonoBehaviour
{

}
public class ChangeBackground : MonoBehaviour
{
    public GameObject day;
    public GameObject night;
    public bool isNight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackGroundChanger()
    {
        if (isNight == false) 
        {
            day.SetActive(false);
            night.SetActive(true);
            isNight = true;
        }

        else
        {
            day.SetActive(true);
            night.SetActive(false);
            isNight = false;
        }
    }
}
