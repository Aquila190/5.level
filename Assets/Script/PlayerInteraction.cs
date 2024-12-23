using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject nearbyObject; // Yakýndaki nesneyi tutacak deðiþken

    void Update()
    {
        // E tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.E) && nearbyObject != null)
        {
            // Nesneyi alma iþlemi
            PickUpObject();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Alýnabilir nesneyle temas
        if (collision.CompareTag("Pickup"))
        {
            nearbyObject = collision.gameObject; // Yakýndaki nesneyi kaydet
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Nesne alandan çýktýðýnda
        if (collision.CompareTag("Pickup"))
        {
            nearbyObject = null; // Yakýndaki nesneyi sýfýrla
        }
    }

    void PickUpObject()
    {
        // Nesneyi yok et veya bir envantere ekle
        Debug.Log($"Nesne alýndý: {nearbyObject.name}");
        Destroy(nearbyObject); // Nesneyi sahneden kaldýr
    }
}
