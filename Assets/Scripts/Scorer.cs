using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    void Start(){
        Debug.Log("You have bumped into something 0 times.");
    }
    int score=0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag!="Hit"){
            score++;
            Debug.Log("You have bumped into something "+ score +" times");
        }
        
    }
}
