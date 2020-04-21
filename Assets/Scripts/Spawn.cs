using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemy;

    private void Awake()
    {
        StartCoroutine(CreateEnemyInRandomPoint());
    }

    private IEnumerator CreateEnemyInRandomPoint()
    {
        var timer = new WaitForSeconds(2f);

        while (true)
        {
            if (_spawnPoints.Length > 0 && _enemy!= null)
            {
                Transform position = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
                Instantiate(_enemy, position);
            }
            yield return timer;
        }
    }
}
