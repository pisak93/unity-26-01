using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.tag=="Player")
        {
            Destroy(otro.gameObject);
        }
        else if (otro.gameObject.tag == "Piso")
        {
            Destroy(gameObject);
        }
    }
}
