using UnityEngine;

public class Dancer : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private Animator animator;
    private Transform target;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayerInRange()
    {
        animator.SetBool("inRange", true);

        target = playerObject.transform;
    }

    public void PlayerOutOfRange()
    {
        animator.SetBool("inRange", false);

        target = null;
    }

    private void Update()
    {
        if (target != null)
        {
            Quaternion targetRotation = Quaternion.LookRotation((new Vector3(target.position.x, transform.position.y, target.position.z) - transform.position).normalized);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 1f);
        }
    }
}
