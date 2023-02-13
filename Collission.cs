using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
     [SerializeField] Color32 hasPackageColor=new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor=new Color32(1,1,1,1);

    SpriteRenderer car;
    bool hasPackage=false;
    void  Start() {
     {
           car=GetComponent<SpriteRenderer>();
     }
    }
   private void OnCollisionEnter2D(Collision2D other)
   {
    Debug.Log("Hello I bumped with Badha");

   }
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Package"&&!hasPackage){
     Debug.Log("Hello I picked the package");
     car.color=hasPackageColor;
     hasPackage=true;
     Destroy(other.gameObject,5000);
    }
     if(other.tag=="Customer"&&hasPackage){
Debug.Log("Hello I delivered the package");
car.color=noPackageColor;
hasPackage=false;
     }
   }
}
