using UnityEngine;

public class ManualControl : MonoBehaviour
{
    [SerializeField] private float speed = 100.0f;
    [SerializeField] private float rotateSpeed = 10.0f;
    [SerializeField] private GameInput gameInput;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new(inputVector.x, 0f, inputVector.y);
        transform.position += speed * Time.deltaTime * moveDir;

        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
    }
}
