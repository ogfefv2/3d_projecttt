using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private GameObject diamondVisual;
    void Update()
    {
        diamondVisual.transform.Rotate(xAngle: 0, yAngle: 250+Time.deltaTime, zAngle: 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
