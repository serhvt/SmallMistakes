using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
   public void PlayGame()
    {
        StartCoroutine(LoadSceneDelay(1));
    }
    public void MainMenu() 
    {
        StartCoroutine(LoadSceneDelay(0));
    }
    IEnumerator LoadSceneDelay(int scene,float delay = 0.5f) 
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
