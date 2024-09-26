using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsDetects : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) {
        Debug.Log("C. Enter - " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other) {
        Debug.Log("C. Stay - " + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other) {
        Debug.Log("C. Exit - " + other.gameObject.name);
    }

}
