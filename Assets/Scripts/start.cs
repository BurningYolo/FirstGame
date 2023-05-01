using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void ChangeToSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
