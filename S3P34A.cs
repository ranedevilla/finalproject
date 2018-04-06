using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S3P34A : MonoBehaviour {
	public InputField i;
	public GameObject t;
	public GameObject k;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void check()
	{
		string x = i.text.ToLower();
		if (x == "botox injection" || x == "botox" || x == "injection") {
			t.SetActive (true);
			k.SetActive (false);
		} else {
			k.SetActive (true);
		}
	}
}
