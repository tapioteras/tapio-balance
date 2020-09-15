using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
  {
  	if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene("End");
  	}
  }
}
