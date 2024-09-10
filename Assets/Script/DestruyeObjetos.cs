using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeObjetos : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemigo")){
            GameObject obj = other.gameObject;
            Destroy(obj);
        }
    }

}
