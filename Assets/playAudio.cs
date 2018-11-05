using UnityEngine;
using System.Collections;

public class playAudio : MonoBehaviour {
	public AudioSource suara;
	public AudioClip[] clip;
	private bool isPlaying = false;
	// Use this for initialization
	void Start(){
		clip = new AudioClip[] {
			(AudioClip)Resources.Load ("sound/001"),
			(AudioClip)Resources.Load ("sound/112"),
			(AudioClip)Resources.Load ("sound/113"),
			(AudioClip)Resources.Load ("sound/114"),
		};
	}

	public void LoadSound(){
		string name = Vuforia.DefaultTrackableEventHandler.soundFile;
		switch(name){
		case("11"):
			suara.clip = clip [0];
			break;
		case("12"):
			suara.clip = clip [1];
			break;
		case("13"):
			suara.clip = clip [2];
			break;
		case("14"):
			suara.clip = clip [3];
			break;
		default:
			suara.clip = clip [0];
			break;
		}
		playSound();
	}
	public void playSound () {
		if (!isPlaying) {
			suara.Play ();
			isPlaying = true;
		} else {
			suara.Pause ();
			isPlaying = false;
		}

	}

}
