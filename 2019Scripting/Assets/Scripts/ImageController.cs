
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent; 
    public UnityEvent UpdateUnityEvent;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    
   public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
   private void Update () {
       UpdateImageEvent.Invoke();
        }
}
