using UnityEngine;
using System.Collections;

public class WallControl : MonoBehaviour
{

	[SerializeField]
	private Transform m_Floor;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_Floor.position.y - transform.position.y > 30)
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y + 120, transform.position.z);
		}
	}
}
