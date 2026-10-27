using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Vida : MonoBehaviour
{
 public int VidaMaxima = 100;
    public int VidaAtual;
    public TextMeshProUGUI TextoVida;
    void Start()
    {
        VidaAtual = VidaMaxima;
        AtualizarTela();
    }
    public void TomarDano(int dano)
    {
        VidaAtual -= dano;
        if (VidaAtual < 0) VidaAtual = 0;

        Debug.Log("Tomou" + dano + " de dano!");
        AtualizarTela();

        if (VidaAtual == 0)
        {
            Morrer();
        }
    }
    public void Curar(int cura)
    {
        VidaAtual += cura;
        if (VidaAtual > VidaMaxima) VidaAtual = VidaMaxima;
        Debug.Log("Curou" + cura + " de vida!");
        AtualizarTela();
    }
    public bool EstaComVidaCheia()
    {
        return VidaAtual == VidaMaxima;
    }

    void Morrer()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void AtualizarTela()
    {
        TextoVida.text = "Vida: " + "/" + VidaMaxima;
    }
    void Update()
    {
        
    }
}
