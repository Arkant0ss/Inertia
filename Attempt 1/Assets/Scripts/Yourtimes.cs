using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yourtimes : MonoBehaviour
{
    public Text yourtimes;

    private void Update() //I will have to add one of these for each level
    {
        yourtimes.text = "Your Times \n \n" + PlayerPrefs.GetFloat("Level1", 0f) + " sec \n" + PlayerPrefs.GetFloat("Level2", 0f) + " sec \n" 
            + PlayerPrefs.GetFloat("Level3", 0f) + " sec \n" + PlayerPrefs.GetFloat("Level4", 0f) + " sec \n" + PlayerPrefs.GetFloat("Level5", 0f) + 
            " sec \n" + PlayerPrefs.GetFloat("Level6", 0f) + " sec \n" + PlayerPrefs.GetFloat("Level7", 0f) + " sec \n" + PlayerPrefs.GetFloat("Level8", 0f) + " sec \n" + PlayerPrefs.GetFloat("BossFight", 0f)
            + " sec \n" + PlayerPrefs.GetFloat("Shooter", 0f) + " sec \n" + PlayerPrefs.GetFloat("Overall", 0f) + " sec \n" + PlayerPrefs.GetFloat("HighScore", 0000f);
    }


}
