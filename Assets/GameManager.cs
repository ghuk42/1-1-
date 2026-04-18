using UnityEngine;
using UnityEngine.UI; // UI 사용을 위해 필요
using UnityEngine.SceneManagement; // 씬 전환을 위해 필요

public class GameManager : MonoBehaviour
{
    public Image timerImage; // UI 이미지 연결용
    public float timeLimit = 15f; // 제한 시간 15초
    private float currentTime;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            // 시간 감소
            currentTime -= Time.deltaTime;

            // UI 이미지의 Fill Amount 업데이트 (1에서 0으로)
            timerImage.fillAmount = currentTime / timeLimit;
        }
        else
        {
            // 15초가 지나면 다음 게임(씬)으로 이동
            NextLevel();
        }
    }

    void NextLevel()
    {
        // 다음 씬의 이름을 넣으세요. (예: "NextGameScene")
        // 미리 Build Settings에 씬이 등록되어 있어야 합니다.
        SceneManager.LoadScene("NextGameScene");
    }
}
