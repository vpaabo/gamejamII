using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float startSpeed;

    public float acceleration;

    public float speed;


    private void Start()
    {
        speed = startSpeed;
    }
    void Update()
    {
        speed += acceleration * Time.deltaTime * 0.0001f;
        acceleration += 0.01f;
        gameObject.transform.position += new Vector3(Input.GetAxis("Horizontal") * 0.1f, 0,speed);


        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level01");
        }

        if (rb.position.y < -1f) 
        {
            print("pos.y < 1");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

    
