using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float m_MovementSpeed = 1.0f;
    private Vector2 m_dir;
    public SpriteRenderer spriteRenderer;

    public Sprite spriteUp;
    public Sprite spriteDown;
    public Sprite spriteLeft;
    public Sprite spriteRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = m_dir * (m_MovementSpeed * Time.deltaTime);
        transform.position = transform.position + vel;
        
        // handle animations
        if (m_dir.x < -.05f)
        {
            spriteRenderer.sprite = spriteLeft;
        }
        else if (m_dir.x > .05f)
        {
            spriteRenderer.sprite = spriteRight;
        }
        if (m_dir.y < -.05f)
        {
            spriteRenderer.sprite = spriteDown;
        }
        else if (m_dir.y > .05f)
        {
            spriteRenderer.sprite = spriteUp;
        }
    }

	public void Move(InputAction.CallbackContext context)
    {
        m_dir = context.action.ReadValue<Vector2>().normalized;
    }
}
