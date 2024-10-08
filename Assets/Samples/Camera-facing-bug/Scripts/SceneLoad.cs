using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Load(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }
}