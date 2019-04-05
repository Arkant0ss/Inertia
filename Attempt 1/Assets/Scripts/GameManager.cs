using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public int bosslives;
    public GameObject completeLevelUI;

    public Transform player;
    public Text highScore;
    public Text timerText;
    //private bool timeractive;
    public float timer;
 
    void Start()
    {
        if (PlayerPrefs.GetString("TimerActive", "Off") == "On")
        {
            FindObjectOfType<TimeKeeper>().TimerOn();
            highScore.text = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name, 0f).ToString();
        }        
        if (SceneManager.GetActiveScene().name == "Endless")
        {
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
        //else if (timeractive == true)
        //
        //    highScore.text = PlayerPrefs.GetFloat("TopTime", 0f).ToString();
        //}
    }
    void Update()
    {
        if (FindObjectOfType<TimeKeeper>().timeTrial == true)
        {
            timer = Time.timeSinceLevelLoad;
            timerText.text = timer.ToString();
        }
        else
        {
 
            timerText.text = "";
            highScore.text = "";
        }
    }

    public void CompleteLevel()
    {
        if (FindObjectOfType<TimeKeeper>().timeTrial == true)
        {
            BestTime();
        }
            
        completeLevelUI.SetActive(true);
    }
    public void loselife()
    {
        bosslives -= 1;
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
                      
            if (SceneManager.GetActiveScene().name == "Endless")
            {
                ScoreKeeper(); 
            }
            Invoke("Restart", restartDelay - 1); //reminder to change this later           
        }
            
    }
    public void ScoreKeeper()
    {
        int currentScore = (int)player.position.z;
        if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highScore.text = currentScore.ToString();
            Debug.Log(currentScore.ToString());
        }
    }
    public void BestTime()
    {
        float currentScore = timer;
        if (currentScore < PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name, 10000f))
        {
            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, currentScore);
            highScore.text = currentScore.ToString();
            Debug.Log(currentScore.ToString());
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ScoreReset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
   
    public void Restart()
    {
        if (FindObjectOfType<TimeKeeper>().timeTrial == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FindObjectOfType<TimeKeeper>().TimerOn();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
