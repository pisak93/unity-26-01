using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidad;
    public float fuerzaSalto;
    public Vector2 direccion;
    public PlayerInput playerInput;
    public bool isGrounded;
    private int orientacion = 1;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void FixedUpdate()
    {
        float velocidadNueva = direccion.x * velocidad;
        rb.linearVelocity = new Vector2(velocidadNueva, rb.linearVelocity.y);
        transform.localScale = new Vector3(orientacion, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        Flip();
        CheckGrounded();
    }

    private void OnMove(InputValue value)
    {
        direccion = value.Get<Vector2>();
    }

    private void OnJump(InputValue value)
    {
        if (value.isPressed && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }

    }
    public void Flip()
    {
        if (direccion.x > 0.1f)
        {
            orientacion = 1;
        }
        else if (direccion.x < -0.1f)
        {
            orientacion = -1;
        }
    }
    public void CheckGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
    }
}
