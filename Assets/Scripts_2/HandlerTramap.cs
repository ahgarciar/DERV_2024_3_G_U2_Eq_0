using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerTramap : MonoBehaviour
{
    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;

    Transform spawn;
    [SerializeField] List<GameObject> lista_enemigos;

    int contador_enemigo_actual;

    void Awake() {
        //vincula el gameobject por codigo 
        spawn = GameObject.Find("SpawnEnemigos").transform;    
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempo_para_nuevo_enemigo = 3;
        contador_enemigo_actual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //tarea 23 de septiembre - > generar version con corrutina y enter/exit trigger
    private void OnTriggerStay(Collider other) {
        tiempo_en_trigger += Time.deltaTime;
        if (tiempo_en_trigger > tiempo_para_nuevo_enemigo){
            //genera enemigo; /////////////////////////////////////////////////
            lista_enemigos[contador_enemigo_actual].transform.position = 
                    spawn.position;
            /////AGREGA UNA FUERZA DE EMPUJE AL ENEMIGO HACIA ABAJO 
            lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce(
                -1 * 20f * transform.up , ForceMode.Impulse
            );
            ////
            contador_enemigo_actual++;
            contador_enemigo_actual %= contador_enemigo_actual; 
            /////////////////////////////////////////////////////////////////
            tiempo_en_trigger = 0;
        }
    }
}
