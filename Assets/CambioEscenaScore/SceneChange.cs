using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_score;

    // Update is called once per frame
    void Update()
    {
        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if (escenaActiva == 0){ //escena de inicio
            if(Input.GetKeyDown(KeyCode.Space)){
                cambioEscena(1); //la escena principal
            }
        }
        else if (escenaActiva == 2){
            texto_score.text = PlayerPrefs.GetInt("Score", 0).ToString();
        }
    }

    public void cambioEscena(int index){
        SceneManager.LoadScene(index);
    }

    public void cambioEscena(int index, int score){
        PlayerPrefs.SetInt("Score", score);
        cambioEscena(index);
    }
}
