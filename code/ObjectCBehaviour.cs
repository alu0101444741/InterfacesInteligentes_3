using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCBehaviour : MonoBehaviour {
  private GameObject player;
  private GameObject[] objectsA;
  private GameObject[] objectsB;
  private GameObject objectsBTarget;
  private int proximity_sensitivity = 1;
  private float rotationSpeed = 1.0f;
  void Start(){
    this.player = GameObject.Find("Cube_Player");
    this.objectsA = GameObject.FindGameObjectsWithTag("TypeA");
    this.objectsB = GameObject.FindGameObjectsWithTag("TypeB");
    this.objectsBTarget = GameObject.Find("Target");
  }

  void Update(){
    // If player gets closer enough
    if(checkPlayerIsNear()) {
      for (int i = 0; i < this.objectsA.Length; ++i) {
        if (this.objectsA[i].GetComponent<ObjectABehaviour>().isGrounded) {
          this.objectsA[i].GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
          this.objectsA[i].GetComponent<Renderer>().material.color = Random.ColorHSV();
          this.objectsA[i].GetComponent<ObjectABehaviour>().isGrounded = false;
        }               
      }

      Transform targetTransform = this.objectsBTarget.GetComponent<Transform>();

      for (int i = 0; i < this.objectsB.Length; ++i) {
        Transform objectTransform = this.objectsB[i].GetComponent<Transform>();

        Vector3 targetDirection = targetTransform.localPosition - objectTransform.localPosition;
        float singleStep = this.rotationSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(objectTransform.forward, targetDirection, singleStep, 0.0f);

        Debug.DrawRay(objectTransform.position, newDirection, Color.red, 1, false);
        
        // *******************************  Debug  *******************************
        /*string objectPosition = this.objectsB[i].name +
                                "(X:" + objectTransform.localPosition.x.ToString() +
                                ", Z:" +  objectTransform.localPosition.z.ToString() + ")";
        string targetPosition = objectsBTarget.name +
                                "(X:" + targetTransform.localPosition.x.ToString() +
                                ", Z:" +  targetTransform.localPosition.z.ToString() + ")";

        Debug.Log("Drawing a line from " + objectPosition + " to " + targetPosition);*/
        // *******************************         *******************************
        
        objectTransform.localRotation = Quaternion.LookRotation(newDirection);        
      }
    }
  }

  private bool checkPlayerIsNear() {    
    if (Mathf.Abs(player.transform.position.x - this.transform.position.x) <= this.proximity_sensitivity) {
      if (Mathf.Abs(player.transform.position.z - this.transform.position.z) <= this.proximity_sensitivity) {
        return(true);
      }
    }
    return(false);
  }
}
