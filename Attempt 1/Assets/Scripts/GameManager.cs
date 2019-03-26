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
    //private Vector3 defPos = new Vector3(0f,1f,0f);

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Endless")
        {
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        } else
        {
            highScore.text = "";
        }
            
    }
    public void CompleteLevel()
    {
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
            
            int currentScore = (int) player.position.z;
            if (SceneManager.GetActiveScene().name == "Endless")
            {
                if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", currentScore);
                    highScore.text = currentScore.ToString();
                    Debug.Log(currentScore.ToString());
                }
            }
            Invoke("Restart", restartDelay - 1); //reminder to change this later

            
           
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
