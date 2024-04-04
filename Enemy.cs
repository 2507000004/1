using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField]
    public GameObject player;
    [SerializeField]
    [Range(0.1f, 2)]
    [Header("Регулирует скорость перемещения сущности")]
    public float moveSpeed = 0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float tempMS = moveSpeed;
        if (player.transform.position.x < transform.position.x)
            tempMS *= -1;
        rb.AddForce(new Vector2(tempMS, 0), ForceMode2D.Force);
        if (transform.position.y < -5) SceneManager.LoadSceneAsync("WinScene");
    }
}
