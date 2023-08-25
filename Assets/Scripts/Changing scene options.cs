using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingopScene : MonoBehaviour
{
    public string SceneToload;
    public void Changingoptionscene()
    {
        SceneManager.LoadScene(SceneToload);
    }
}