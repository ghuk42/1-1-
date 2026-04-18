using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject[] eggs;
    public float spawnInterval = 1.0f; // 떨어지는 간격
    public float rangeX = 8.0f; // 좌우 범위

    // 추가: 최소 몇 개에서 최대 몇 개까지 떨어뜨릴지 설정
    public int minSpawn = 1;
    public int maxSpawn = 5;

    void Start()
    {
        InvokeRepeating("SpawnEgg", 0f, spawnInterval);
    }

    void SpawnEgg()
    {
        // 핵심: 이번 타임에 몇 개를 만들지 랜덤으로 정함!
        // maxSpawn + 1을 해줘야 maxSpawn 숫자까지 포함해서 나옵니다.
        int count = Random.Range(minSpawn, maxSpawn + 1);

        for (int i = 0; i < count; i++)
        {
            int randomIndex = Random.Range(0, eggs.Length);
            float randomX = Random.Range(-rangeX, rangeX);

            // 높이도 살짝 랜덤하게 줘서 서로 겹치지 않게 함
            Vector3 spawnPos = new Vector3(randomX, Random.Range(6f, 9f), 0f);

            Instantiate(eggs[randomIndex], spawnPos, Quaternion.identity);
        }
    }
}
