using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Rather than GetComponent<Door>() below, just reference it directly
    public Door Door;
    public GameObject Keypoof;

    void Update()
    {
        //Not required, but for fun why not try adding a Key Floating Animation here :)
    }

    public void OnKeyClicked()
    {
        // Use gameObject.transform.position directly ( it is a Vector3! )
        Instantiate(Keypoof, gameObject.transform.position, transform.rotation);

        // Call the Unlock() method on the Door
        Door.Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }
}