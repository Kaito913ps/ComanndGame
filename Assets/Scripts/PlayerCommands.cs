using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommands : MonoBehaviour
{
    public PlayerStats _playerSatas;
    public EnemyStats _enemyStats;
    [SerializeField, Header("所持できるアイテムの最大数")]
    private int _maxItems = 5;
    [SerializeField, Header("現在のアイテムの数")]
    private int _currentItems = 5;

    /// <summary>
    // 攻撃コマンド
    /// </summary>
    public void AttackCommand()
    {
        //ダメージ量の計算
        //var damage =
        //敵キャラクターのステータスを取得（
               //.TakeDamage();

    }

    /// <summary>
    /// スキルコマンド
    /// </summary>
    public void Skill()
    {
        //スキル発動時の処理(80％の確率で3回の攻撃を跳ね返す)
        if (Random.value <= 0.8f)
        {
            for(int i = 0; i < 3; i++)
            {
                //敵キャラクターのステータスを取得
                //攻撃を跳ね返す
            }
        }
    }
    /// <summary>
    /// アイテムコマンド
    /// </summary>
    public void Item()
    {
        if(_currentItems > 0)
        {
            //
            //int hpRecoveryAmount = 回復量
            // HPを回復させる
            //_playerSatas.RecoverHp();
            //道具の数を減らす
            _currentItems--;
        }
        else
        {
            //道具がない場合の処理
            Debug.Log("道具がないため使用できません！");
        }
    }
}
