using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Objetos tipo B --> CUBOS
public class ObjectBBehaviour : MonoBehaviour {
  private Transform transform;
  //private Transform objectsATransform;
  //private GameObject[] objectsA;
  private GameObject objectC;

  private Notificador notificador;

  private float rotationSpeed = 1.0f;

  void Start(){
    this.transform = this.GetComponent<Transform>();
    //this.objectsA = GameObject.FindGameObjectsWithTag("TypeA");
    //this.objectC = GameObject.FindWithTag("TypeC");

    this.notificador = GameObject.Find("Cube_Player");
    this.notificador.changeObjectB += this.collisionWithObjectA;
    this.notificador.changeObjectAB += this.collisionWithObjectC;
  }  

  void collisionWithObjectA(){
    this.transform.localScale += new Vector3(0.1f, 0.3f, 0.1f);
  }

  void collisionWithObjectC(){
    Vector3 targetDirection = targetTransform.localPosition - this.transform.localPosition;
    Vector3 newDirection = Vector3.RotateTowards(this.transform.forward, targetDirection, this.rotationSpeed * Time.deltaTime, 0.0f);   
    
    // *******************************  Debug  *******************************
    /*string objectPosition = this.objectsB[i].name +
                            "(X:" + objectTransform.localPosition.x.ToString() +
                            ", Z:" +  objectTransform.localPosition.z.ToString() + ")";
    string targetPosition = objectsBTarget.name +
                            "(X:" + targetTransform.localPosition.x.ToString() +
                            ", Z:" +  targetTransform.localPosition.z.ToString() + ")";

    Debug.Log("Drawing a line from " + objectPosition + " to " + targetPosition);*/
    // *******************************         *******************************

    Debug.DrawRay(this.transform.position, newDirection, Color.red, 1, false);
    objectTransform.localRotation = Quaternion.LookRotation(newDirection); 
  }

  void Update(){
      
  }

  /*void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Cube_Player") {      
      for (int i = 0; i < this.objectsA.Length; ++i) {
        this.objectsA[i].transform.LookAt(this.objectC.transform.position);
        this.objectsA[i].transform.position += this.objectsA[i].transform.forward;
      }      
    }
  }*/
}
