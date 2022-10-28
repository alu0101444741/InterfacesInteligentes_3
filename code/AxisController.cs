using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstController : MonoBehaviour {  
  private new Transform transform;
  public int movementSpeed;
  public int rotationSpeed;
  //private new Rigidbody rigidbody;
  //public int force_multiplier;

  void Start(){
    this.transform = GetComponent<Transform>();
    //this.rigidbody = GetComponent<Rigidbody>();

    this.movementSpeed = 5;
    this.rotationSpeed = 3;
    //this.force_multiplier = 1;
  }

  void Update(){
    this.move();
    this.mouseRotation();
    //this.moveWithPhysics();
  }

  void move() {
    this.transform.position += Input.GetAxis("Vertical") * (this.transform.forward * Time.deltaTime) * this.movementSpeed;
    this.transform.position += Input.GetAxis("Horizontal") * (this.transform.right * Time.deltaTime) * this.movementSpeed; 
  }

  void mouseRotation() {
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");
    //float mouseZ = Input.GetAxis("Mouse Z");
    this.transform.Rotate(new Vector3(-mouseY * rotationSpeed, mouseX * rotationSpeed, 0));
    this.transform.localRotation = this.transform.rotation;//.Rotate(new Vector3(-mouseY * rotationSpeed, -mouseX * rotationSpeed, 0));
  }
/*
  void moveWithPhysics() {
    if (Input.GetKey(KeyCode.W)) this.rigidbody.AddForce(Vector3.forward * this.force_multiplier);
    if (Input.GetKey(KeyCode.A)) this.rigidbody.AddForce(Vector3.left * this.force_multiplier);
    if (Input.GetKey(KeyCode.S)) this.rigidbody.AddForce(Vector3.back * this.force_multiplier);
    if (Input.GetKey(KeyCode.D)) this.rigidbody.AddForce(Vector3.right * this.force_multiplier);
  }
*/
}