using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1_Movimiento : MonoBehaviour
{
    [SerializeField] float velocidad = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate( Vector3.forward * velocidad * Time.deltaTime );
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.Translate( Vector3.forward * velocidad * -1 * Time.deltaTime );
        }



    }
}
