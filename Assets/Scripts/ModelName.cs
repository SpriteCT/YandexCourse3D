using TMPro;
using UnityEngine;

public class ModelName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void SetName(string name)
    {
        _text.text = name;
    }
}
