using UnityEngine;
using System.Collections;

public class FiredBullet : MonoBehaviour 
{
    public GameObject m_bulletPrefap;
    
    public KeyCode m_firedKey;

    public float m_fFiredDelay;     // 미사일 발사 딜레이
    public float m_fDelayTime;     // 미사일 발사 딜레이 적용시간
    public float m_fDestroyTime;   // 미사일 유지시간
    public float m_fBulletSpeed;   // 미사일 속도

    void Update()
    {
        if (Input.GetKey(m_firedKey) && Time.time > m_fFiredDelay)
        {

            m_fFiredDelay = Time.time + m_fDelayTime;
            GameObject bullet = Instantiate(m_bulletPrefap, transform.position, transform.rotation) as GameObject;
            bullet.rigidbody.AddForce(transform.TransformDirection(new Vector3(0, 0, 1) * m_fBulletSpeed));

            Destroy(bullet, m_fDestroyTime);
        }
    }
}
