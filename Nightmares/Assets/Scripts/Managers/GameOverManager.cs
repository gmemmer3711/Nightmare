﻿using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public WinngZone inZone;
	public bool playerInWin;
	GameObject player;


    Animator anim;
	float restartTimer;

	void Start(){
		GetComponentInChildren <WinngZone> ();
	}

    void Awake()
    {
        anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");

    }


    void Update()
    {
		if (inZone.playerInWin == true) {
		//if (playerInWin == true) {
			anim.SetTrigger ("Winner");
					print("G-O playerInWin == true");
		}

        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;
        }

    }


	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			inZone.playerInWin = true;
			anim.SetTrigger ("Winner");
			//anim.SetBool ("Win") = true;

			print("G-O player in win");
		}
	}
}
