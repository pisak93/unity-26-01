using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    public float velocidad = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moverPersonaje();

    }

    void moverPersonaje()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal*velocidad,0,vertical*velocidad);

        rb.velocity=new Vector3(direccion.x,rb.velocity.y,direccion.z);

        if(direccion != Vector3.zero)
        {
             Quaternion rotacionObjetivo = Quaternion.LookRotation(direccion);

              Quaternion rotacionSuave = Quaternion.Slerp(rb.rotation, rotacionObjetivo, 10f * Time.deltaTime);
              
             rb.MoveRotation(rotacionSuave);
        }
    }
}
