using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour
{
    bool winLevel = false;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger Event");
        ParticleSystem endZone = GameObject.FindGameObjectWithTag("Finish").GetComponent<ParticleSystem>();
        var em = endZone.emission;
        em.enabled = false;
        winLevel = true;
        //Add it so they can't move for a bit.

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    void OnGUI(){
        if (winLevel)
        {
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = 100;
            myStyle.normal.textColor = Color.red;
            GUI.Label(new Rect(50, 50, Screen.width, Screen.height), "You beat this level!", myStyle);
        }
    }
}