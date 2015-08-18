using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Configuration : MonoBehaviour {

    public Canvas configCanvas;
    public GameObject trackedPrefab;
    public Text hostnameText;
    public Text objectsText;
    public Toggle viconToggle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DisableCanvas()
    {
        configCanvas.enabled = false;
        // create objects from config
        var hostname = hostnameText.text;
        var objects = objectsText.text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var isVicon = viconToggle.isOn;
        Debug.Log("ObjectsText: " + objectsText.text);
        Debug.Log("Instantiating " + objects.Length + " tracked objects.");
        foreach (var obj in objects)
        {
            var newTracked = Instantiate(trackedPrefab);
            Tracker tracker;
            if (isVicon)
            {
                tracker = newTracked.AddComponent<TrackerVicon>();
            }
            else
            {
                tracker = newTracked.AddComponent<Tracker>();
            }
            tracker.host = hostname;
            tracker.obj = obj;
        }
    }
}
