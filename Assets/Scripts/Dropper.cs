using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer visibility;
    Rigidbody body;

    [SerializeField] float waitTime=5f;
    // Start is called before the first frame update
    void Start()
    {
        visibility=GetComponent<MeshRenderer>();
        body= GetComponent<Rigidbody>();
        visibility.enabled=false;
        body.useGravity=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time>waitTime){
            visibility.enabled = true;
            body.useGravity=true;
        }

        
    }
}
