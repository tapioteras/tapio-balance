using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStart : MonoBehaviour
{
	public int highscore;
	public TextMeshPro highscore_text;
  public bool touched = false;

	void Start() {
    touched = false;
 		highscore_text = GameObject.Find("highscore_text").GetComponent<TextMeshPro>();
		highscore = PlayerPrefs.GetInt("highscore", highscore);
 		highscore_text.text = "highScore: " + highscore;
	}

  void Update()
  {
      touched = !touched && Input.touchCount > 0;
      if (Input.GetKeyDown("space") || touched)
      {
          SceneManager.LoadScene("Game");
      }
  }
}
