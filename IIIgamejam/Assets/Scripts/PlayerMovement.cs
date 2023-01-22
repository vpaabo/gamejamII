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
        speed += acceleration * Time.deltaTime * 0.001f;
        acceleration += 0.001f;
        gameObject.transform.position += new Vector3(Input.GetAxis("Horizontal") * 0.5f, 0, speed) * Time.timeScale;


        

        if (rb.position.y < -1f) 
        {
            print("pos.y < 1");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

    
