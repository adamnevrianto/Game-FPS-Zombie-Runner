using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSouce;

	// Use this for initialization
	void Start () {
        audioSouce = GetComponent<AudioSource>();
	}

    void OnMakeInitialHeliCall()
    {
        print(name + " OnMakeInitialHeliCall");
        audioSouce.clip = initialHeliCall;
        audioSouce.Play();
        Invoke("InitialReply", initialHeliCall.length + 1f);
    }

    void InitialReply()
    {
        audioSouce.clip = initialCallReply;
        audioSouce.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
