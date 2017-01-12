using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D physics;
    public float speed;
    public Vector2 movement;
    // Use this for initialization
    void Start() {
        physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Options.option1)
        {
            movement = new Vector2(0, 0.3f);
        }
        else
        {
            movement = new Vector2(0, -0.3f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = (transform.right * Time.deltaTime * -speed).x;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = (transform.right * Time.deltaTime * speed).x;
        }

        movement = movement + (Vector2)(transform.position);

        physics.MovePosition(movement);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BlackBlock")
        {
            Destroy(col.gameObject);
        } 
    }
}
