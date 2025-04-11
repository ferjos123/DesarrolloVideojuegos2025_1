using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Knight; // Arrastra aquí el GameObject de tu personaje desde el Editor
    public float suavizado = 5f; // Ajusta para que el movimiento sea más fluido
    private Vector3 offset; // Distancia inicial entre cámara y personaje

    void Start()
    {
        offset = transform.position - Knight.position; // Calcula la diferencia inicial
    }

    void LateUpdate() // Usamos LateUpdate para que la cámara se actualice AFTER del movimiento del personaje
    {
        Vector3 posicionObjetivo = Knight.position + offset;
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado * Time.deltaTime);
    }
}
