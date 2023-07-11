using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField, Header("�ő�HP")]
    private int _maxHp;
    [SerializeField, Header("���݂�HP")]
    private int _currentHp;
    void Start()
    {
        _currentHp = _maxHp;
    }

    /// <summary>
    /// �_���[�W���󂯂�
    /// </summary>
    /// <param name="damage">�_���[�W��</param>
    public void TakeDamage(int damage)
    {
        _currentHp -= damage;
        if (_currentHp < 0)
        {
            _currentHp = 0;
        }
    }
}
