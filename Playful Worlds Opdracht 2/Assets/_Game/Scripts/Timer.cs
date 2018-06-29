using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public GameManager gameManager;
    public int timeLeft = 10  ;
    public Text countdownText;
	// Use this for initialization
	void Start () {
        StartCoroutine("CountDown");
	}
	
	// Update is called once per frame
	void Update () {
        countdownText.text = ("Starting in " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("CountDown");
            gameManager.NextLevel();
            
        }
	}
    IEnumerator CountDown()
    { while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
      
    }
}
