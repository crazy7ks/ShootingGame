using UnityEngine;
using System.Collections;

public class EnemyObject : MonoBehaviour 
{
    public GameObject m_EffectPrefap;

    public float m_fSpeed;

	void Start ()
    {
	
	}

	void Update () 
    {
        Vector3 pos = transform.position;
        pos.z -= m_fSpeed * Time.deltaTime;
        transform.position = pos;
	}

    void OnCollisionEnter( Collision _col )
    {
        Destroy(_col.gameObject);        
        GameObject effect = Instantiate(m_EffectPrefap, transform.position, transform.rotation) as GameObject;
        Destroy(transform.gameObject);
    }
}
