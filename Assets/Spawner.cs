using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject m_prefab;
    private float m_timer = 90;
    int floors = 3;
    float yPos = 1;
    // Use this for initialization
    void Start() //fuck detta
    {
        for (int j = 0; j < floors; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(m_prefab, new Vector3(Random.Range(-10f, 10f), transform.position.y + Random.Range((yPos * 10f - 30), -(yPos * 15f + 30)), transform.position.z), Quaternion.identity);
            }
            yPos++;
        }
        
        /*for (int i = 0; i < 10; i++)
        {
            Debug.Log("Aids:" + i);
            Instantiate(m_prefab, new Vector3(Random.Range(-10f, 10f), transform.position.y + -0.2f, transform.position.z), Quaternion.identity);
        }
        */
    }
}

    // Update is called once per frame
//    void Update()
//    {
//        if (m_timer > 0)
//        {
//            m_timer--;
//        }

//        else if (m_timer <= 0)
//        {
//            m_timer = 90;
//            Instantiate(m_prefab, new Vector3(Random.Range(-4f, 4f), transform.position.y + Random.Range(10f, -20f), transform.position.z), Quaternion.identity);
//        }
//    }
//}

