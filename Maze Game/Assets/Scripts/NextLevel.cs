using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger Event");
        SceneManager.LoadScene(2);
    }
}