using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScene : MonoBehaviour
{
    public string SceneChanger;
    public void Changingscene()
    {
    SceneManager.LoadScene("Game");
    }
}
