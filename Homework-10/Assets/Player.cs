using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed = 5.0f;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal") * playerSpeed;
        float verticalSpeed = Input.GetAxis("Vertical") * playerSpeed;

        Vector2 move = new Vector2(horizontalSpeed, verticalSpeed) * Time.deltaTime;

        body.MovePosition((Vector2)transform.position + move);
    }
}

