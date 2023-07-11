using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField, Header("最大HP")]
    private int _maxHp;
    [SerializeField, Header("現在のHP")]
    private int _currentHp;
    void Start()
    {
        _currentHp = _maxHp;
    }

    /// <summary>
    /// ダメージを受ける
    /// </summary>
    /// <param name="damage">ダメージ量</param>
    public void TakeDamage(int damage)
    {
        _currentHp -= damage;
        if (_currentHp < 0)
        {
            _currentHp = 0;
        }
    }
}
