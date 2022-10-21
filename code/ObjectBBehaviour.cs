using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBBehaviour : MonoBehaviour {
  public Transform objectsATransform;
  public GameObject[] objectsA;
  void Start(){
    this.objectsA = GameObject.FindObjects;
  }

  // Update is called once per frame
  void Update(){
      
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Cube_Player") {
      this.transform.localScale += new Vector3(0.1f, 0, 0.1f);
    }
  }
}
