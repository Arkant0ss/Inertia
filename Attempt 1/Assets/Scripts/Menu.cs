using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuscreen;
    public GameObject hofscreen;
    public GameObject levelscreen;
    
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HallofFame()
    {
        hofscreen.SetActive(true);
        menuscreen.SetActive(false);
        
    }
    public void MenuScreen()
    {
        menuscreen.SetActive(true);
    }
    public void LevelSelector()
    {
        hofscreen.SetActive(false);
        menuscreen.SetActive(false);
        levelscreen.SetActive(true);
    }
    public void HowToSelector()
    {
        hofscreen.SetActive(false);
        menuscreen.SetActive(false);
        levelscreen.SetActive(false);

    }
    public void TutortialChooser() // make this better later
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(gameObject.name);
        //Debug.Log(gameObject.name);
    }
    public void Level1Chooser()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2Chooser()
    {
        SceneManager.LoadScene(3);
    }
    public void Level3Chooser()
    {
        SceneManager.LoadScene(4);
    }
    public void Level4Chooser()
    {
        SceneManager.LoadScene(5);

    }
    public void Level5Chooser()
    {
        SceneManager.LoadScene(6);

    }
    public void Level6Chooser()
    {
        SceneManager.LoadScene(7);

    }
    public void Level7Chooser()
    {
        SceneManager.LoadScene(8);

    }
    public void BossfightChooser()
    {
        SceneManager.LoadScene(9);

    }

    public void EndlessChooser() //must fix this
    {
        SceneManager.LoadScene(11);

    }


}
