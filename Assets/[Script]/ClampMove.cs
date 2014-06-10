using UnityEngine;
using System.Collections;

public class ClampMove : MonoBehaviour
{
    public GameObject m_moveZone;
    public float m_fSpeed;

    private float m_fMinX;
    private float m_fMaxX;

    public KeyCode leftKey;
    public KeyCode rightKey;

	void Start ()
    {
        m_fMinX = m_moveZone.transform.position.x - m_moveZone.renderer.bounds.size.x / 2;
        m_fMaxX = m_moveZone.transform.position.x + m_moveZone.renderer.bounds.size.x / 2;
	}

	void Update () 
    {
        int h = 0;

        if (Input.GetKey(leftKey)) h = -1;
        if (Input.GetKey(rightKey)) h = 1;

        Vector3 pos = transform.position;
        pos.x += m_fSpeed * h * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, m_fMinX, m_fMaxX);

        transform.position = pos;
	}
}