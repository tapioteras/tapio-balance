using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Retry : MonoBehaviour
{
	public int highscore;
	public TextMeshPro highscore_text;

	public TextMeshPro counter_text;
	public int counter;

	public bool touched = false;

	void Start() {
		touched = false;
	}

  // Update is called once per frame
  void Update()
  {
		counter = PlayerPrefs.GetInt("counter", counter);
		highscore = PlayerPrefs.GetInt("highscore", highscore);

		if (counter > highscore) {
			PlayerPrefs.SetInt("highscore",  counter);
			highscore = counter;
    }

		highscore_text = GameObject.Find("highscore_text").GetComponent<TextMeshPro>();
 		highscore_text.text = "highscore: " + highscore;

 		counter_text = GameObject.Find("counter_text").GetComponent<TextMeshPro>();
 		counter = PlayerPrefs.GetInt("counter", counter);
 		counter_text.text = "current: " + counter;

 		touched = !touched && Input.touchCount > 0;

    if (Input.GetKeyDown("space") || touched) {
        SceneManager.LoadScene("Start");
    }
  }
}
