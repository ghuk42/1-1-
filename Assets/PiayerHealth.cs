using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // 목숨 개수를 3개로 설정
    public int lives = 3;

    public void TakeDamage(int damage)
    {
        // 달걀과 부딪히면 목숨이 1씩 감소
        lives -= 1;
        Debug.Log("남은 목숨: " + lives);

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("게임 오버! 목숨이 모두 사라졌습니다.");

        // 게임을 일시정지시키고 싶다면 아래 주석을 해제하세요
        // Time.timeScale = 0; 

        // 여기에 게임 오버 팝업창을 띄우는 코드를 나중에 추가하면 됩니다.
    }
}
