using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S2L12 : MonoBehaviour {
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
		if (x == "dictionary") {
			SceneManager.LoadScene ("S2L12");
		} else {
			t.SetActive (true);
		}
	}
}
