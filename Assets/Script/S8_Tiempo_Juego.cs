using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class S8_Tiempo_Juego : MonoBehaviour
{
    [SerializeField] SceneChange auxiliar; //se ocupa vincular el componente por el inspector
    [SerializeField] S9_DestruyeObjetosReporta acceso_score;

    int contador_segundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;
    // Start is called before the first frame update
    void Start()
    {
     contador_segundos = 10;   
     Texto_Tiempo.text = contador_segundos.ToString();
     StartCoroutine("corrutinaTiempo");
    }

    IEnumerator corrutinaTiempo(){
        while(contador_segundos>=0){
            Texto_Tiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(0.25f); //el proceso se ejectuara cada 
            //cuarto de segundo
        }
        
        Debug.Log("El juego termino :D!");
        int score = acceso_score.contador_enemigos; 
        auxiliar.cambioEscena(2, score); //escena fin

    }
}
