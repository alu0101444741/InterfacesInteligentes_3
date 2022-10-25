using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBBehaviour : MonoBehaviour {
  private Transform objectsATransform;
  private GameObject[] objectsA;
  private GameObject objectC;
  void Start(){
    this.objectsA = GameObject.FindGameObjectsWithTag("TypeA");
    this.objectC = GameObject.FindWithTag("TypeC");
  }

  // Update is called once per frame
  void Update(){
      
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Cube_Player") {      
      for (int i = 0; i < this.objectsA.Length; ++i) {
        this.objectsA[i].transform.LookAt(this.objectC.transform.position);
        this.objectsA[i].transform.position += this.objectsA[i].transform.forward;
      }      
    }
  }
}
