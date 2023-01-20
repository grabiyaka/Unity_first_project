using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float vSpeed = 150f, hSpeed = 300f, _thrust = 1000f;

    private Rigidbody _rb;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * vSpeed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y , v));
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
        } 
    }

    private void OnCollisionStay(Collision other) {
        // Debug.Log("Collide");
    }

    private void OnCollisionExit(Collision other) {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "TriggerMain"){
            Debug.Log("Trigger Correct");
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.name == "TriggerMain"){
            Debug.Log("Trigger Stay");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "TriggerMain"){
            gameObject.SetActive(false);
        }
    }
}
