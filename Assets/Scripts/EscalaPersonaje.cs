using UnityEngine;

public class EscalaPersonaje : MonoBehaviour
{
    public float velocidadEscala = 1f;

    public KeyCode teclaCrecer = KeyCode.R;
    public KeyCode teclaDecrecer = KeyCode.F;

    public float escalaMinima = 0.3f;
    public float escalaMaxima = 3f;

    void Update()
    {
        float cambio = 0f;

        if (Input.GetKey(teclaCrecer))
        {
            cambio = velocidadEscala * Time.deltaTime;
        }
        if (Input.GetKey(teclaDecrecer))
        {
            cambio = -velocidadEscala * Time.deltaTime;
        }
        float nuevaEscala = transform.localScale.x + cambio;

        nuevaEscala = Mathf.Clamp(
            nuevaEscala,
            escalaMinima,
            escalaMaxima
            );

        transform.localScale = new Vector3(
            nuevaEscala,
            nuevaEscala,
            nuevaEscala
            );
        
    }
}
