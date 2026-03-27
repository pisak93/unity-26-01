using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarRocas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject roca;
    private float delay;
    void Start()
    {
        delay = Random.Range(0f,5f);
        InvokeRepeating("generar",delay,4f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void generar()
    {
        Instantiate(roca,transform.position,transform.rotation);
          transform.position = new Vector3(Random.Range(-3f,3f),transform.position.y,Random.Range(-17f,20f));
    }
}
