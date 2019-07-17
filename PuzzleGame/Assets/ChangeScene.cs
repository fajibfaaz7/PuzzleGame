using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    void Start()
    {
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(1);
    }

   
}
