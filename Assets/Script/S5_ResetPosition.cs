using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_ResetPosition : MonoBehaviour
{
    [SerializeField] Transform origen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            transform.position = origen.transform.position;
        }
    }
}
