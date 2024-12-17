using UnityEngine;

public class GameState : MonoBehaviour {
    private void Start() {
        CatchChecker.OnSonicCatch += GameOver;
    }

    public void GameOver(string message) {
        print(message);
    }
}