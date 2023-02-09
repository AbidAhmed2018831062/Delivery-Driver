using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    bool hasPackage=false;
   private void OnCollisionEnter2D(Collision2D other)
   {
    Debug.Log("Hello I bumped with Badha");

   }
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Paclage"&&!hasPackage){
     Debug.Log("Hello I picked the package");
     hasPackage=true;
    }
     if(other.tag=="Customer"&&hasPackage){
Debug.Log("Hello I delivered the package");
hasPackage=false;
     }
   }
}
