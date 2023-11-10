using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Scripting;

public class Monster : MonoBehaviour
{
    // ���� ����
    public GameObject onOffObject; // Ȱ��ȭ/��Ȱ��ȭ�� ��ü
    public float Speed = 10f; // ������ �⺻ �̵� �ӵ�
    private Transform TR; // ������ Ʈ������
    private Transform PlayerTR; // �÷��̾��� Ʈ������
    private Transform MOM;
    private NavMeshAgent agent; // ������ NavMeshAgent
    public trigger tr; // Ʈ���� Ŭ����
    public trtr trigrrer;
    private bool aaa = false;
    public float MonsterStop = 2; //���� �����ð�


   

    // Start �Լ��� ù ��° ������ ������Ʈ ���� ȣ��˴ϴ�.
    void Start()
    {
        // Ʈ���� �̺�Ʈ�� ���� �̺�Ʈ �ڵ鷯 ����
        tr.onTriggerEnterEvent += ActiveObj; // Ʈ���ſ� ������ �� Ȱ��ȭ �̺�Ʈ�� ���� �ڵ鷯 �߰�
        tr.onTriggerExitEvent += InactiveObj; // Ʈ���ſ��� ���� �� ��Ȱ��ȭ �̺�Ʈ�� ���� �ڵ鷯 �߰�
        trigrrer.onTriggerTimeEnterEvent += TriggerTime;


        // �ʿ��� ������Ʈ �� ���� �ʱ�ȭ

        TR = GetComponent<Transform>(); // �ڱ� �ڽ��� Transform ������Ʈ ��������
        PlayerTR = GameObject.FindWithTag("Player").GetComponent<Transform>(); // "Player" �±׸� ���� ���� ������Ʈ�� Transform ��������
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent ������Ʈ ��������

        
    }

   

    // Update �Լ��� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        if (MOM == null) 
        {
            aaa = true;
        }
        // ������Ʈ�� �ӵ� ����
        agent.speed = Speed; // ������ �̵� �ӵ� ����
        if (aaa == true)
        {
            agent.destination = PlayerTR.position; // �÷��̾��� ��ġ�� �������� �����Ͽ� �÷��̾ �����մϴ�.
        }
        else
        {
            MOM = GameObject.FindWithTag("MOM").GetComponent<Transform>();
            agent.destination = MOM.position;
        }
    }
    
    // onTriggerEnter �̺�Ʈ�� ���� Ȱ��ȭ �Լ�
    public void ActiveObj()
    {
        //Speed = 1f; // Ʈ���� ���Խ� ������ �̵� �ӵ��� 1f�� ����
        Debug.Log("�����"); // ����� �޽��� ���
        aaa =true;
    }

    // onTriggerExit �̺�Ʈ�� ���� ��Ȱ��ȭ �Լ�
    public void InactiveObj()
    {
        // ���⿡ Ʈ���ſ��� ���� �� ��Ȱ��ȭ�� ���� �߰�
    }

    public void TriggerTime()
    {
        Debug.Log("����");
        StartCoroutine(StopForSeconds(MonsterStop)); // 5�ʰ� �����ϴ� �ڷ�ƾ�� ����
    }
    private IEnumerator StopForSeconds(float seconds)
    {
       
        agent.isStopped = true;
        yield return new WaitForSecondsRealtime(seconds); // ������ �ð� ���� ����մϴ�.
        agent.isStopped = false;
       

        
    }
}

