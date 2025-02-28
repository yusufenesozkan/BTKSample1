using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float pushForce = 1000f;
    private float movement;
    [SerializeField]
    private float speed = 5f;
    public Vector3 respawnPoint;
    private GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.respawnPoint = this.transform.position;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        
        
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);
        rb.linearVelocity = new Vector3(movement* speed , rb.linearVelocity.y, rb.linearVelocity.z);
        fallDedector();
    }

    private void OnCollisionEnter(Collision other)
    {
        //if it is barrier
        //respawn
        if (other.collider.CompareTag("Barrier"))
        {
            gameManager.isGameEnding = true;
            gameManager.RespawnPlayer();
        }
        

    }
    private void fallDedector()
    {
        if (rb.position.y < -2)
        {
            gameManager.isGameEnding = true;
            gameManager.RespawnPlayer();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.transform.position.z>125)
        {
            gameManager.LevelUp();
            print("level tamam");
        }
    }
}
