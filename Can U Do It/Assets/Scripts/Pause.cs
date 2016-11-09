using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    bool showGUI = false;
    GameObject canvas;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showGUI = !showGUI;
        }

        if (showGUI == true)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
