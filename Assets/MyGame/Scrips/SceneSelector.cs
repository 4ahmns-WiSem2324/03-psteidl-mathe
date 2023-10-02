using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("PrimeNumbers");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void Scene4()
    {
        SceneManager.LoadScene("Scene4");
    }
}
