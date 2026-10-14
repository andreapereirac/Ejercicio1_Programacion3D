using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 2f;
    public Vector3 direccion = new Vector3(0, 0, 1);

    void Update()
    {
        transform.position += direccion.normalized * velocidad * Time.deltaTime;
        
    }
}
