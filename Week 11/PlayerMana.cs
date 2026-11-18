using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
         if (Keyboard.current.rKey.isPressed)
        {
            animator.SetBool("usemana", true);
        }
        else
        {
            animator.SetBool("usemana", false);
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            mana -= 10;
        }
        manaText.text = "Mana: " + mana;
    }
}

