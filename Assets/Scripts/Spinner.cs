using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed=150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAngle=0, zAngle=0;
        float yAngle=Time.deltaTime*spinSpeed;
        transform.Rotate(xAngle,yAngle,zAngle);
        
    }
}
