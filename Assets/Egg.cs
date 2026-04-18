using UnityEngine;

public class Egg : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 'Floor'라는 태그를 가진 오브젝트에 닿으면 삭제
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
        // 'Player'라는 태그를 가진 오브젝트(토끼)에 닿으면 삭제
        else if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어의 체력을 깎는 함수 호출 (아래 2번에서 작성)
            collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
