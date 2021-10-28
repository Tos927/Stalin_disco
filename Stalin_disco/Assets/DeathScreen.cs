using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

    public static DeathScreen instance;

    //public void OnPlayerDeath()
    //{
    //    GameObject.SetActive(true);
    //}

    public void RetryButton()
    {
        SceneManager.LoadScene("Thomas");
        deathScreen.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
