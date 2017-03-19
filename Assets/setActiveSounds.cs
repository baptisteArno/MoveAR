using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

public class setActiveSounds : MonoBehaviour {

    private AudioSource otherAudio;
    // Use this for initialization
    void Start () {
        otherAudio = GameObject.Find("Test").GetComponent<AudioSource>();
        Debug.Log(otherAudio);
    }
	
	// Update is called once per frame
	void Update () {
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        if (!otherAudio.isPlaying)
        {
            otherAudio.Play();
            Debug.Log("ok");
        }

        // Iterate through the list of active trackables
        Debug.Log("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables)
        {
            Debug.Log("Trackable: " + tb.TrackableName);
        }
    }
}
