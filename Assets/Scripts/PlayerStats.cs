using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField,Header("�ő�HP")]
    private int _maxHp;
    [SerializeField, Header("���݂�HP")]
    private int _currentHp;
    [SerializeField, Header("�ő�SP")]
    private int _maxSp;
    [SerializeField, Header("���݂�SP")]
    private int _currentSp;
    void Start()
    {
        //�ő�HP�ŏ�����
        _currentHp = _maxHp;
        //�ő�SP�ŏ�����
        _currentSp = _maxSp;
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

    /// <summary>
    /// SP�������
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public bool ConsumeSp(int amount)
    {
        if(_currentSp >= amount)
        {
            _currentSp -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// �v���C���[���񕜂���悤�ɂ���
    /// </summary>
    /// <param name="amount">�񕜗�</param>
    public void RecoverHp(int amount) 
    {
        _currentHp += amount;
        if(_currentHp > _maxHp)
        {
            _currentHp = _maxHp;
        }
    }
}
