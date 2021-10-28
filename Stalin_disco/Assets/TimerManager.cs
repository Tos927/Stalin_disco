using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
	public Text TimerText;

	public static bool playing = true;
	private bool TimerOut;
	// Time in seconds 271s = 4m31s
	private float timer = 271;
	public GameObject gameOverScreen;



    private void Start()
    {
		gameOverScreen.SetActive(false);

	}
    void Update()
	{
		// Stop decreasing the timer if the game is paused or if the timer is at 0.
		if (playing == true && timer >= 0)
		{
			timer -= Time.deltaTime;
			int minutes = Mathf.FloorToInt(timer / 60f);
			int seconds = Mathf.FloorToInt(timer % 60f);
			int milliseconds = Mathf.FloorToInt((timer * 100f) % 100f);

			TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

			// Prevents from setting the time to 00:00:00 and start GameOver before the end.
			return;
		}	

		// Play that only one time
        if (playing == true && !TimerOut)
        {
			TimerText.text = ("00") + ":" + ("00") + ":" + ("00");
			gameOverScreen.SetActive(true);
			Time.timeScale = 0;
			// Put the GameOver actions
			Debug.Log("You Lose !!");



			TimerOut = true;
		}
	}
}
