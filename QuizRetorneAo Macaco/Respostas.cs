
using System;
public class Respostas
{
    //Atributos
    private String Nome;
    private String RGM;
    private int TotalAcerto;
    private int TotalErro;


    //Bob Construtor

    //Construtor com todas infos
    public Respostas (String p_Nome, String p_RGM, int p_TotalAcerto, int p_TotalErro)
    {
        this.Nome = p_Nome;
        this.RGM = p_RGM;
        this.TotalAcerto = p_TotalAcerto;
        this.TotalErro = p_TotalErro;
    
    }

    //The real default Bob Construtor
    public Respostas ()
    {

    } 

    //Getter´s/Setter´s

    //Get
    public String GetNome() { return this.Nome; }
    public String GetRGM() { return this.RGM; }
    public int GetTotalAcerto() { return this.TotalAcerto; }
    public int GetTotalErro() { return this.TotalErro; }


    //Set

    public void SetNome(String p_Nome) { this.Nome = p_Nome; }
    public void SetRGM(String p_RGM) { this.RGM = p_RGM; }

    public void SetTotalAcerto(int p_TTAcerto) { this.TotalAcerto = p_TTAcerto; }
    public void SetTotalErro(int p_TTErro) { this.TotalErro = p_TTErro; }



}

