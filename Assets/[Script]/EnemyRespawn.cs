using UnityEngine;
using System.Collections;

public class EnemyRespawn : MonoBehaviour 
{
    public GameObject m_enemyPrefap1;
    public GameObject m_enemyPrefap2;
    public GameObject m_enemyPrefap3;

    public float m_fRespawnDelay;
    public float m_fDelayTime;

    public float m_fMinX;
    public float m_fMaxX;

    public int m_iMaxHP;

	void Start () 
    {
        m_fMinX = transform.position.x - renderer.bounds.size.x / 2;
        m_fMaxX = transform.position.x + renderer.bounds.size.x / 2;
        EnemyObject.m_stMaxHP = m_iMaxHP;
	}

	void Update () 
    {
        if (Time.time > m_fRespawnDelay)
        {
            m_fRespawnDelay = Time.time + m_fDelayTime;
            Vector3 pos = transform.position;
            pos.x = Random.Range(m_fMinX, m_fMaxX);
            GameObject enemy = Instantiate(m_enemyPrefap1, pos, transform.rotation) as GameObject;
        }
	}
}
