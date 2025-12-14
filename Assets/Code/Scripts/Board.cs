using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private GameObject[] applePrefeb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitBoard();
    }

    // 사과 출력하기
    void InitBoard()
    {        
        float spaceX = 0.95f;
        float spaceY = 0.85f;

        int rowCnt = 17;
        int colCnt = 10;

        for(int row = 0; row < rowCnt; row++)
        {
            for(int col = 0; col < colCnt; col++)
            {
                int randIdx = Random.Range(0, 9);  // 1~9번 사과 인덱스
                // 사과 배치
                Vector3 pos = new Vector3((row - (int)(rowCnt * 0.5f)) * spaceX, (col - colCnt * 0.5f) * spaceY, 0f);
                Instantiate(applePrefeb[randIdx], pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
