using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float startSpeed;

    public float acceleration;

    public float speed;

    public float jumpForce;


    private void Start()
    {
        speed = startSpeed;
    }
    void Update()
    {
        speed += acceleration * Time.deltaTime * 0.001f;
        acceleration += 0.001f * Time.timeScale;
        gameObject.transform.position += new Vector3(Input.GetAxis("Horizontal") * 0.3f, 0, speed) * Time.timeScale;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space pressed");
            if (transform.position.y > 1.5f) return;

            rb.AddForce(new Vector3(0, jumpForce, 0),ForceMode.Impulse);
        }

        if (rb.position.y < -1.5f) 
        {
            print("pos.y < -1");
            FindObjectOfType<GameManager>().EndGame();
        }

        if(transform.position.z >= 1000)
        {
            print("game won!!");
            GameManager.PauseGame();
        }
    }
}

    
