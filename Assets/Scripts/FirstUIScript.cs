using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstUIScript : MonoBehaviour
{
    /*public Button button;
    public string newScene;

    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);  
    }

    private void OnButtonClick()
    {
        SceneManager.LoadScene(newScene);
    }*/

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
