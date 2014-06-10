using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour
{
    public float m_fSpeed;

	void Update ()
    {
        Vector2 pos = renderer.material.mainTextureOffset;
        pos.y -= m_fSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = pos;
	}
}
