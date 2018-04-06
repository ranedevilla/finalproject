using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2L21 : MonoBehaviour {
	public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void change(){
		StartCoroutine(LoadAfterAnim());
	}

	public IEnumerator LoadAfterAnim()
	{
		text.SetActive (true);
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("S2L2-1");
	}
}
