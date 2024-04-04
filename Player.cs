using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    bool onGround = false;
    [HideInInspector]
    public float jumpForce = 0.3f;
    [HideInInspector]
    public float moveSpeed = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical") && onGround)
        {
            rb.AddForce(new UnityEngine.Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        float horizontalAxis = Input.GetAxis("Horizontal");
        if (horizontalAxis != 0)
        {
            rb.AddForce(new UnityEngine.Vector2(horizontalAxis * moveSpeed, 0));
        }
        if (transform.position.y < -5) SceneManager.LoadSceneAsync("LoseScene");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            onGround = true;
        else if (collision.gameObject.tag == "Enemy")
            SceneManager.LoadSceneAsync("LoseScene");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            onGround = false;
    }
}
