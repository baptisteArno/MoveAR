using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class TrackableList : MonoBehaviour {

	AudioClip clips;
	// Use this for initialization
	void Start () {
		clips = new AudioClip[6];
    	clips[0] = Resources.Load(Resources.Load("AudioSourcePrefab",GameObject).GetComponent(AudioSource));  //  First clip
	}
	
	// Update is called once per frame
	void Update () {
		// Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();
 
        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
 
       // Iterate through the list of active trackables
        Debug.Log ("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables) {
            Debug.Log("Trackable: " + tb.TrackableName);
        }
	}
}
