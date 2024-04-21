using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public void MainMenu()
    {
        StartCoroutine(LoadSceneDelay(0));
    }
    IEnumerator LoadSceneDelay(int scene, float delay = 0.5f)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scene);
    }
}
