using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;


    void Update()
    {
        if (Input.GetKey("return"))
        {
            LoadNextLevel();
        }
         void LoadNextLevel()
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
            IEnumerator LoadLevel(int levelIndex)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(levelIndex);

        }
        
    }
}