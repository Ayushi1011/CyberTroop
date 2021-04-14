using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_s : MonoBehaviour
{
     public void Back()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
   }
}