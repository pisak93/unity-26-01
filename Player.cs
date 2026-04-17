using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad;
    public float direccion;
    public bool saltando;
    public float fuerzaSalto;
    public bool isGrounded;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;


    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    direccion = Input.GetAxis("Horizontal");
    CheckGrounded();

    float velocidadNueva=direccion*velocidad;


     rb.velocity= new Vector2(velocidadNueva,rb.velocity.y);


     saltando = Input.GetButtonDown("Jump");

     if(saltando && isGrounded){

     rb.velocity= new Vector2(rb.velocity.x,fuerzaSalto);

     }

     void CheckGrounded(){

         isGrounded=Physics2D.OverlapCircle(groundCheck.position,checkRadius,groundLayer);

     }



    }
}
