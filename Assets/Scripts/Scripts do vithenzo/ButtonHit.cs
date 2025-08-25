using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonHit : MonoBehaviour
{
    public int contador;
    [SerializeField] TMP_Text countText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ClickMorte()
    {
        contador++;
        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void trocaDeCena()
    {
        SceneManager.LoadScene("Upgrades");
    }
    private void UpdateUI()
    {
        countText.text = "Mortes: " + contador.ToString();
    }
}
