using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommands : MonoBehaviour
{
    public PlayerStats _playerSatas;
    public EnemyStats _enemyStats;
    [SerializeField, Header("�����ł���A�C�e���̍ő吔")]
    private int _maxItems = 5;
    [SerializeField, Header("���݂̃A�C�e���̐�")]
    private int _currentItems = 5;

    /// <summary>
    // �U���R�}���h
    /// </summary>
    public void AttackCommand()
    {
        //�_���[�W�ʂ̌v�Z
        //var damage =
        //�G�L�����N�^�[�̃X�e�[�^�X���擾�i
               //.TakeDamage();

    }

    /// <summary>
    /// �X�L���R�}���h
    /// </summary>
    public void Skill()
    {
        //�X�L���������̏���(80���̊m����3��̍U���𒵂˕Ԃ�)
        if (Random.value <= 0.8f)
        {
            for(int i = 0; i < 3; i++)
            {
                //�G�L�����N�^�[�̃X�e�[�^�X���擾
                //�U���𒵂˕Ԃ�
            }
        }
    }
    /// <summary>
    /// �A�C�e���R�}���h
    /// </summary>
    public void Item()
    {
        if(_currentItems > 0)
        {
            //
            //int hpRecoveryAmount = �񕜗�
            // HP���񕜂�����
            //_playerSatas.RecoverHp();
            //����̐������炷
            _currentItems--;
        }
        else
        {
            //����Ȃ��ꍇ�̏���
            Debug.Log("����Ȃ����ߎg�p�ł��܂���I");
        }
    }
}
