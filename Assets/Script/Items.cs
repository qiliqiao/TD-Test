using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour 
{
	[SerializeField]
	private Transform[] m_Object;

	private bool m_Pausing;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		m_Pausing = GameObject.Find("Player").GetComponent<GameOver>().pausing;

		if (m_Pausing == false) 
		{
			if (collision.transform.tag == "Floor") 
			{
				Destroy (gameObject);
			}

			if (collision.transform.tag == "Player" && transform.tag == "battery") 
			{
				Destroy (gameObject);
			}
		}
	}

}
