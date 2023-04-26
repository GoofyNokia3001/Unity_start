using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void ToStart()
	{
		SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
	}

    public void Stop()
    {
        Application.Quit();
    }
    public void ToScene()
    {
        SceneManager.LoadScene("First", LoadSceneMode.Single);
    }

}
