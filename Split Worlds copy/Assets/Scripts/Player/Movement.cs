using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rbN;
    private Rigidbody rbD;


    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rbN = GetComponent<Rigidbody>();
        rbD = GameObject.Find("PlayerD").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x  = Input.GetAxis("Horizontal");
        
        rbD.velocity = new Vector3(x * speed, rbD.velocity.y, rbD.velocity.z);
        rbN.velocity = new Vector3(x * speed, rbN.velocity.y, rbN.velocity.z);

    }

    
}
