using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour
{
    public void SceneLoad(int index) 
    {
        SceneManager.LoadScene(index);
    }
  
}
