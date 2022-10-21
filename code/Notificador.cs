using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador : MonoBehaviour {
  
  public delegate void mensaje();
  public event mensaje OnMiEvento;
  public int contador;

  void Start(){
    this.contador = 0;
  }

  void Update(){
    this.contador ++;
    if (this.contador % 1000 == 0) {
      OnMiEvento();
    }
  }
}
