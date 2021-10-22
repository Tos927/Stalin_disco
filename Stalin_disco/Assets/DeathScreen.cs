using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

    public static DeathScreen instance;

    public void OnPlayerDeath()
    {
        deathScreen.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("GUI_screen");
        deathScreen.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
