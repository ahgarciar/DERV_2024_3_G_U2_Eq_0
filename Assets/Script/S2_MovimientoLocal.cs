using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_MovimientoLocal : MonoBehaviour
{

    [SerializeField] float velocidad = 5f;

    // Start is called before the first frame update
    void Start()
    {        
        //transform.Rotate(0, 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.W)){
            //transform.Translate( transform.forward * velocidad * Time.deltaTime);            
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S)){
            //transform.Translate( transform.forward * velocidad * -1 * Time.deltaTime);            
            transform.position += transform.forward * -1 * velocidad * Time.deltaTime;
        }

    }
}
