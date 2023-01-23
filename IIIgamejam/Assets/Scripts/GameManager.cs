using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerMovement player;

    public static float restartDelay = 2f;


    public KeyCode restartButton;
    public KeyCode pauseButton;
    private static bool paused;


    private void Start()
    {
        paused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }

    public static void PauseGame()
    {
        Time.timeScale = (paused) ? 1 : 0;
        paused = !paused;
    }
    public void EndGame()
    {
        if (player.transform.position.z >= 1000)
        {
            WinGame();
            return;
        }
        else Invoke("Restart", restartDelay);
        
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScreen");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
