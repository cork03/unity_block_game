using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public GameObject gameStartUI;
    public Ball ball;

    public bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameClear != true)
        {
            if (this.DestroyAllBlocks())
            {
                // ゲームクリア
                Debug.Log("ゲームクリア");
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }
    }

    // 全ブロックの削除チェック
    private bool DestroyAllBlocks ()
    {
        foreach (Block block in blocks)
        {
            if (block != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameStart()
    {
        Debug.Log("ゲームスタート");
        ball.Shot();
        gameStartUI.SetActive(false);
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
