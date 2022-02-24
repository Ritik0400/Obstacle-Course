using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //These variables change our movement speed
   [SerializeField] float moveSpeed=8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Method to move player
    void MovePlayer(){
        float xValue=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

}