using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public float starthealth=100f;
    public float health;
    public Image Healthbar;
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
        health = starthealth;
	}
	
	// Update is called once per frame
	void Update () {
        Healthbar.fillAmount = health/starthealth;
        if (health <= 0)
        {
            Die();
        }
	}
    public void Die()
    {
        Debug.Log("Communism will rise again ");

        gameManager.GameOver();
        Destroy(gameObject);

    }
}
