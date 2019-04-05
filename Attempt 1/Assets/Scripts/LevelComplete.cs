using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private bool timeractive;
    private void Start()
    {
        timeractive = FindObjectOfType<TimeKeeper>().timeTrial;
        if (timeractive != true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Invoke("LoadNextLevel", 3f);
            FindObjectOfType<GameManager>().Restart();
            FindObjectOfType<TimeKeeper>().TimerOn();
        }
        
    }
    public void LoadNextLevel()
    {
        
    }
}
