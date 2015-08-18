using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WritePosition : MonoBehaviour {

    Transform root;
    Text text;

	// Use this for initialization
	void Start () {
        root = transform.root;
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = root.position.ToString("F2");
	}
}
