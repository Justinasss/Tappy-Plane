using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanadger : MonoBehaviour
{
    public void ReloadLevel()
    {
        var levelName = SceneManager.GetActiveScene().name;
        SceneManager.loadScene(levelName);
    }
}
