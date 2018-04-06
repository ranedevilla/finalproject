using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	GameManager gameManager;
	public GameObject answer;
	public Text texts;
	// Use this for initialization
	void Start () {
		gameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuestionOne(string ans)
	{
		if (ans == "a" || ans == "b") {
			SceneManager.LoadScene ("S1L2");

		} else if (ans == "2a" || ans == "2b") {
			answer.SetActive (true);
		} else if (ans == "1a" || ans == "1b") {
			answer.SetActive (true);
		} else if (ans == "left home" || ans == "murderer" || ans == "lost") {
			if (ans == "left home") {
				texts.text = "Wrong. She has string of lovers. She must be careful";
				answer.SetActive (true);
			} else if (ans == "murderer") {
				texts.text = "Correct. He would panic because after he murdered someone he will received a message from that person";
				answer.SetActive (true);
			} else if (ans == "lost") {
				texts.text = "Wrong. If found by stranger, he would just ignore it.\t";
				answer.SetActive (true);
			}
		} else if (ans == "bottle A" || ans == "bottle B") {
			if (ans == "bottle A") {
				SceneManager.LoadScene ("L");
			} else {
				SceneManager.LoadScene ("W");
			}
		} else if (ans == "suicide" || ans == "murder") {
			answer.SetActive (true);
			StartCoroutine(LoadAfterAnim());
		}else if (ans == "jw" || ans == "lestrade" || ans == "it") {
			if (ans == "it") {
				SceneManager.LoadScene ("epic");
			} else {
				SceneManager.LoadScene ("L");
			}
		}
	}
	public IEnumerator LoadAfterAnim()
	{
		yield return new WaitForSeconds(10f);
		SceneManager.LoadScene("S2L5");
	}
}
