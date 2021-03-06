﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MultiplayerBehaviour {
    
	public void Die(){
		if(this.gameObject.name == "player1")
			GameManager.score2++;
		if(this.gameObject.name == "player2")
			GameManager.score1++;
		GameObject.Find("Player Scores").GetComponent<Text>().text = GameManager.score1 + "-" + GameManager.score2;
		if(GameManager.score1>99 || GameManager.score2>99)
			ShowEasterEgg();
		if(GameObject.Find("player1") != null && GameObject.Find("player2")!= null)
			GameObject.Find("CameraHolder1").GetComponent<Animator>().SetTrigger("Game Ended");
		gameObject.name = "playerDead";
		GameManager.gameStart = false;
        GameManager.gameStarting = false;
    }


    public AudioClip MoveSound;

    void Update()
    {
        if(transform.position.y < -10000)
        {
            Destroy(this.gameObject);
        }
    }


    public void ShowEasterEgg(){
		GameManager.easter1.gameObject.SetActive(true);
		GameManager.easter2.gameObject.SetActive(true);
    }

}