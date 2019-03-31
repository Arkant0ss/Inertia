using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public bool timeTrial;


    public void TimerOn()
    {
        var objects = GameObject.FindGameObjectsWithTag("TimeKeeper");
        if (timeTrial == true)
        {
            timeTrial = false;

            foreach (var obj in objects)
            {
                obj.GetComponent<TimeKeeper>().timeTrial = false;
            }
        }
        else
        {
            timeTrial = true;
            foreach (var obj in objects)
            {
                obj.GetComponent<TimeKeeper>().timeTrial = true;
            }
        }
        Debug.Log(timeTrial);
    }

}
