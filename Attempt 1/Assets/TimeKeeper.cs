using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public bool timeTrial;


    public void TimerOn()
    {
        //var objects = GameObject.FindGameObjectsWithTag("TimeKeeper");
        if (timeTrial == false)
        {
            timeTrial = true;
            FindObjectOfType<TimeKeeper>().timeTrial = true;

            //foreach (var obj in objects)
            //{
            //    obj.GetComponent<TimeKeeper>().timeTrial = false;
            //}
        }
        //else
        //{
        //    timeTrial = true;
        //    //foreach (var obj in objects)
        //    //{
        //    //    obj.GetComponent<TimeKeeper>().timeTrial = true;
        //    //}
        //}
        Debug.Log(timeTrial);
    }
    public void TimerOff()
    {
        if (timeTrial == true)
        {
            timeTrial = false;
            FindObjectOfType<TimeKeeper>().timeTrial = false;
        }
        Debug.Log(timeTrial);

    }
}