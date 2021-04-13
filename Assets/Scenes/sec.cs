using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sec : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       SceneManager.LoadScene(1);

   }
}
//  if(collision.gameObject.CompareTag("Player"))
//         {
//             isInRange=false;
//             Debug.Log("Player not in range");
//         }   