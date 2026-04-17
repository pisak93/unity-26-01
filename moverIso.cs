using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverIso : MonoBehaviour
{
   
     public float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movimiento = new Vector2(horizontal, vertical);

      rb.velocity = movimiento * velocidad;
    }

  
}
