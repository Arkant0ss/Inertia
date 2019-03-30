using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void regularQuit()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }
    
}
