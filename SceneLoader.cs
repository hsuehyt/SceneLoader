using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // Add this line to include UI namespace

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // Get the button and add a click listener
        Button btn = GameObject.Find("Canvas/Button").GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Load Scene2 when the button is clicked
        SceneManager.LoadScene("Scene2");
    }
}
