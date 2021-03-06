using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	AudioSource audioSource;

	void Start(){
		audioSource = GetComponent<AudioSource>();
		audioSource.loop = true;
		audioSource.Play();
	}

	// Update is called once per frame
	void Update () {
		if(GameManager.gameStarting && audioSource.isPlaying)
			GetComponent<AudioSource>().Pause();
		else if(!GameManager.gameStarting && !audioSource.isPlaying)
			audioSource.Play();
	}

}
