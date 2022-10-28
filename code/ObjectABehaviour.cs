using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Objetos tipo A --> CÁPSULAS
public class ObjectABehaviour : MonoBehaviour {

  private Renderer renderer;
  private new Rigidbody rigidbody;
  public bool isGrounded;  

  private GameObject[] objectsB;
  private GameObject objectC; 

  private PlayerController notificador;

  void Start(){
    this.renderer = this.GetComponent<Renderer>();
    this.rigidbody = this.GetComponent<Rigidbody>();
    this.isGrounded = true;

    //this.objectsB = GameObject.FindGameObjectsWithTag("TypeB");
    //this.objectC = GameObject.FindWithTag("TypeC");    

    this.notificador = GameObject.Find("Cube_Player");

    this.notificador.changeObjectA += this.collisionWithObjectB;
    this.notificador.changeObjectAB += this.collisionWithObjectC;
  }

  void collisionWithObjectB(){
    this.transform.LookAt(this.objectC.transform.position);
    this.transform.position += this.transform.forward;
  }

  void collisionWithObjectC(){
    this.rigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    this.isGrounded = false;
    
    this.renderer.material.color = Random.ColorHSV();    
  }

  void Update(){
      
  }  

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Terrain") {
      this.isGrounded = true;
    }
    /*if (collision.gameObject.name == "Cube_Player") {
      this.objectsB[Random.Range(0, this.objectsB.Length)].transform.localScale += new Vector3(0.1f, 0.3f, 0.1f);
    }*/    
  }

  /*void OnCollisionExit(Collision collision) {
    if (collision.gameObject.name == "Terrain") {
      this.isGrounded = false;
    }
  }*/
}
