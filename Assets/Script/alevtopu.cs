using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public GameObject objectToThrow; 
    public float throwForce = 10f;   
    public float timeToLive = 3f;    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Throw();
        }
    }

    void Throw()
    {
        
        Vector3 throwPosition = transform.position;

        
        GameObject thrownObject = Instantiate(objectToThrow, throwPosition, Quaternion.identity);

        
        Rigidbody2D rb = thrownObject.GetComponent<Rigidbody2D>();

        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; 

        
        Vector2 direction = (mousePosition - throwPosition).normalized;

        
        rb.AddForce(direction * throwForce, ForceMode2D.Impulse);

        
        Destroy(thrownObject, timeToLive); 
    }
}
