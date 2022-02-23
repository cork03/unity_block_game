using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.DestroyAllBlocks())
        {
            // ゲームクリア
            Debug.Log("ゲームクリア");
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

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
    }
}
