using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField,Header("最大HP")]
    private int _maxHp;
    [SerializeField, Header("現在のHP")]
    private int _currentHp;
    [SerializeField, Header("最大SP")]
    private int _maxSp;
    [SerializeField, Header("現在のSP")]
    private int _currentSp;
    void Start()
    {
        //最大HPで初期化
        _currentHp = _maxHp;
        //最大SPで初期化
        _currentSp = _maxSp;
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

    /// <summary>
    /// SPを消費する
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
    /// プレイヤーが回復するようにする
    /// </summary>
    /// <param name="amount">回復量</param>
    public void RecoverHp(int amount) 
    {
        _currentHp += amount;
        if(_currentHp > _maxHp)
        {
            _currentHp = _maxHp;
        }
    }
}
