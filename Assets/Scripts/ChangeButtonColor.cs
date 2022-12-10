using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _color;

    private Color _oldColor;

    public void ChangeOnNewColor()
    {
        _oldColor = _image.color;
        _image.color = _color;
    }

    public void ChangeOnOldColor()
    {
        _image.color = _oldColor;
    }
}
