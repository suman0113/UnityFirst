using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 7f;

    private Vector2 moveinput;
    public float jumpforce = 7f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnJump(InputValue value)
    {
        if (value.isPressed) // 점프 버튼을 누르면
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }

        
        
    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
    }


    void Update()
    {
        if (moveinput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveinput.y > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        transform.Translate(Vector3.right * moveSpeed * moveinput.x * Time.deltaTime);
    }
}
