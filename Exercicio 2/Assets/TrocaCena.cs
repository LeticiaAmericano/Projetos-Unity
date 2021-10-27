using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena: MonoBehaviour
{
    public void CarregarCena (string nome)
    {
        SceneManager.LoadScene(nome);
    }
}