using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectABehaviour : MonoBehaviour {
  private GameObject[] objectsB;
  private new Rigidbody rigidbody;
  public bool isGrounded;
  void Start(){
    this.rigidbody = this.GetComponent<Rigidbody>();
    this.objectsB = GameObject.FindGameObjectsWithTag("TypeB");
    this.isGrounded = true;
  }

  // Update is called once per frame
  void Update(){
      
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Cube_Player") {
      this.objectsB[Random.Range(0, this.objectsB.Length)].transform.localScale += new Vector3(0.1f, 0.3f, 0.1f);
    }
    if (collision.gameObject.name == "Terrain") {
      this.isGrounded = true;
    }
  }

  void OnCollisionExit(Collision collision) {
    if (collision.gameObject.name == "Terrain") {
      this.isGrounded = false;
    }
  }
}
