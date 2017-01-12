using UnityEngine;
using System.Collections;

public class Blodspawner : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D m_physics;
    public GameObject m_prefab2;
    public GameObject player2;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - player2.transform.position;

    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player2.transform.position + offset;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "BlackBlock")
        {
            Instantiate(m_prefab2, transform.position, transform.rotation);
        }
    }
}
