using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCBehaviour : MonoBehaviour {
  private GameObject[] objectsA;
  private GameObject[] objectsB;
  void Start(){
    this.objectsA = GameObject.FindGameObjectsWithTag("TypeA");
    this.objectsB = GameObject.FindGameObjectsWithTag("TypeB");
  }

  // Update is called once per frame
  void Update(){
      
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Cube_Player") {      
      for (int i = 0; i < this.objectsA.Length; ++i) {
        if (this.objectsA[i].GetComponent<ObjectABehaviour>().isGrounded) {
          this.objectsA[i].GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
          this.objectsA[i].GetComponent<Renderer>().material.color = Random.ColorHSV();
        }        
      }

      /*for (int i = 0; i < this.objectsB.Length; ++i) {
        this.objectsA[i].transform.LookAt(this.objectC.transform.position);
        this.objectsA[i].transform.position += this.objectsA[i].transform.forward;
      }     */
    }
  }
}
