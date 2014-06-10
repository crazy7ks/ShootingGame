using UnityEngine;
using System.Collections;

public class DestroyZone : MonoBehaviour 
{
	void Start () 
    {
	
	}
	
	void Update () 
    {
	
	}

    void OnCollisionEnter( Collision _col )
    {
        Debug.Log("엥?");
        Destroy( _col.gameObject );
    }
}
