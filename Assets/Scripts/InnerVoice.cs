using UnityEngine;
using System.Collections;

public class InnerVoice : MonoBehaviour {

	public AudioClip whatHappened;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;

//There is not sound assest yet. Once the right sound asset will be presented, delete comment slashes.
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
        /*
		audioSource.clip = whatHappened;
		audioSource.Play ();
         */
	}
	
	void OnFindClearArea () {
        /*
		print (name + " OnFindClearArea");
		audioSource.clip = goodLandingArea;
		audioSource.Play ();

		Invoke ("CallHeli", goodLandingArea.length + 1f);
         */
	}

	void CallHeli () {
		SendMessageUpwards ("OnMakeInitialHeliCall");
	}

}
