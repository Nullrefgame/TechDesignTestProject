using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public enum Scenes
    {
        Day,
        Midnight,
    }

    public Scenes SceneForLoading;

    public void LoadNewScene()
    {
        SceneManager.LoadScene(((int)SceneForLoading));
    }
}
