using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGravity : MonoBehaviour
{
    private ConstantForce cF;
    private Vector3 forceDirection;
    public float gravity = 9.81f;


    // Start is called before the first frame update
    void Start()
    {
        cF = GetComponent<ConstantForce>();
        forceDirection = new Vector3(0, gravity, 0);
        cF.force = forceDirection;
    }

    // Update is called once per frame
    

    
}
