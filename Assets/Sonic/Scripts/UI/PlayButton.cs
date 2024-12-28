using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayButton : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Start() {
        playButton.onClick.AddListener(HandlePlayPress);
    }

    private void HandlePlayPress() {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex + 1
        );
    }
}