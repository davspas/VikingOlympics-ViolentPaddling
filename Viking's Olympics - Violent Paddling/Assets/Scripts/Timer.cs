using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text textTimer;
    private float tempoDecorrido;
 
	void Update() {
		tempoDecorrido += Time.deltaTime;

		float minutos = tempoDecorrido / 60;
		float segundos = tempoDecorrido % 60;
		float fracao = (tempoDecorrido * 100) % 100;

		textTimer.text = string.Format ("{0:00}:{1:00}:{2:000}", minutos, segundos, fracao);
	}
}
