using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum TypeObjetosSegurity { Casco, ZapatoSeguridad, ChallecoSeguridad, Mameluco }
public class SecurityCount : MonoBehaviour
{
    [SerializeField] int quantityEquipments=0;
    [SerializeField] GameEvent completedProtectiveEquipment;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Objetos")) {
            if(other.GetComponent<TypeSecurity>() != null)
            {
                quantityEquipments++;
                if(quantityEquipments >= Enum.GetValues(typeof(TypeObjetosSegurity)).Length)
                {
                    completedProtectiveEquipment.Raise(); 
                }
            }
        }
    }
}
