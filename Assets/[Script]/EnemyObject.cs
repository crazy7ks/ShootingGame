using UnityEngine;
using System.Collections;

public class EnemyObject : MonoBehaviour 
{
    public GameObject m_deathEffect;
    public GameObject m_hitEffect;
    public static int m_stMaxHP;
    public float m_fSpeed;
    int m_iHP;
    float m_fBackPos;

	void Start ()
    {
        m_iHP = m_stMaxHP;
	}

	void Update () 
    {
        Vector3 pos = transform.position;

        if ( m_fBackPos > 0 )
        {
            pos.z += 0.1f;
            m_fBackPos -= 0.1f;
        }
        else pos.z -= m_fSpeed * Time.deltaTime;

        transform.position = pos;
	}

    void OnCollisionEnter( Collision _col )
    {
        --m_iHP;
        m_fBackPos = 0.5f;
        Destroy(_col.gameObject);
        GameObject crashEffect = Instantiate(m_hitEffect, transform.position, transform.rotation) as GameObject;
        if (m_iHP <= 0)
        {
            GameObject deathEffect = Instantiate(m_deathEffect, transform.position, transform.rotation) as GameObject;
            Destroy(transform.gameObject);
        }        
    }
}
