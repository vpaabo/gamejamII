using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;


    public KeyCode restartButton;
    public KeyCode pauseButton;
    private bool paused;


    private void Start()
    {
        paused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            paused = !paused;
            Time.timeScale = (paused) ? 0 : 1;
            
        }
        else if (Input.GetKeyDown(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }
    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            print("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
