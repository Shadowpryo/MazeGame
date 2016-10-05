using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public GameObject loadingImage;

    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(level);
    }
}