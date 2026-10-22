using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TwoPlayers()
    {
        PlayerPrefs.SetInt("GameMode", 2);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void OnePlayer()
    {
        PlayerPrefs.SetInt("GameMode", 1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
}