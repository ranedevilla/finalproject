using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S2L97 : MonoBehaviour {
	public InputField i;
	public GameObject t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void check()
	{
		string x = i.text.ToLower();
		if (x == "stole" || x == "did not deliver goods" || x == "stolen something") {
			SceneManager.LoadScene ("S2L9-7");
		} else {
			t.SetActive (true);
		}
	}
}
