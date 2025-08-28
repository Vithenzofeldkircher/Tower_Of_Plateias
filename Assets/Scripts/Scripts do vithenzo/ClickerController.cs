using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ClickerController : MonoBehaviour
{
    [SerializeField] TMP_Text countText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AtualizarTexto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AoClicar()
    {
        GameManager.instance.TotalMortes++;
        AtualizarTexto();
    }

    private void AtualizarTexto()
    {
        countText.text = "Mortes: " + GameManager.instance.TotalMortes.ToString();
    }

}
