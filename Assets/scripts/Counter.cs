using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public Text text;
    public TextMeshPro counter_text;
		public int currentCount;
		public int highscore;
		public TextMeshPro highscore_text;

    void Update () {
        counter1();
				applyHighlight();
    }
    void Start() {
        text = GetComponent<Text>();
    }

    void applyHighlight() {
    	GameObject.Find("Player")
    	.transform.GetChild(0)
    	.gameObject.transform.GetChild(0)
    	.gameObject.SetActive(currentCount > highscore && currentCount > 800);
    }

    void counter1 () {
	    counter_text = GameObject.Find("counter_text").GetComponent<TextMeshPro>();
   		counter_text.text = "current: " + currentCount;
   		currentCount++;

   		highscore_text = GameObject.Find("highscore_text").GetComponent<TextMeshPro>();
   		highscore = PlayerPrefs.GetInt("highscore", highscore);
   		highscore_text.text = "highscore: " + highscore;

	    PlayerPrefs.SetInt("counter",  currentCount);
    }
}
