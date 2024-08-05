using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.5f;
    [SerializeField] GameObject onCollectEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0, rotationSpeed, 0, Space.World); 
    }

    void OnTriggerEnter(Collider other){
      if (other.CompareTag("Player")){
        Destroy(gameObject);
        Instantiate(onCollectEffect, transform.position, transform.rotation);
      }
    }
}
