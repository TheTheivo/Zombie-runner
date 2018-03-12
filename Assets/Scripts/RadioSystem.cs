using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour {

	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;

	private AudioSource audioSource;
//sound assets not presnt yet. Once the right assets will bbe presented, delete comment slashes.
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	/*
	void OnMakeInitialHeliCall () {
		print (name + " OnMakeInitialHeliCall");
		audioSource.clip = initialHeliCall;
		audioSource.Play ();
		Invoke ("InitialReply", initialHeliCall.length + 1f);
     */
	}
/*
	void InitialReply () {
		audioSource.clip = initialCallReply;
		audioSource.Play ();
		BroadcastMessage ("OnDispatchHelicopter");
	}
 *.

}
