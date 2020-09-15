using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpSpeed = 1.0f;
    public bool InAir = true;

    void FixedUpdate() {
        GetComponent<Rigidbody>().AddRelativeForce(
            Vector3.forward * Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed
        );

        GetComponent<Rigidbody>().AddRelativeForce(
            Vector3.right * Input.GetAxis("Vertical") * Time.fixedDeltaTime * (speed / 2)
        );
    }

    void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && !InAir) {
			GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;
		}


if (Input.touchCount > 0)
      {
          var touch = Input.GetTouch(0);
          if (touch.position.x < Screen.width/2)
          {
             if(Input.GetTouch(0).phase == TouchPhase.Began)
             {
                 Debug.Log("Left click");
             }
          }
          else if (touch.position.x > Screen.width/2)
          {
             if (Input.GetTouch(0).phase == TouchPhase.Began)
             {
                 Debug.Log("Right click");
             }
         }
      }

	}

	void OnCollisionEnter(Collision other) {
		InAir = other.gameObject.tag != "platformTag";
  }

  void OnCollisionExit(Collision other)
   {
     InAir = true;
   }
}
