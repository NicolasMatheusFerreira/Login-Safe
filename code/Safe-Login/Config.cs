using System;
using System.IO;
using System.Collections.Generic;

public class Config
{
    Login login;
    Admin admin;
    List<string> cargos;

    public Config(Login login, Admin admin)
    {
        this.login = login;
        this.admin = admin;
        this.cargos = new List<string>();

        ImportaConfiguracoes();
    }
    public void ImportaConfiguracoes()
    {
        ImportaCargo("cargos.txt");
    }
    public void ExportaConfiguracoes()
    {
        admin.ExportaAdmin();
    }

    public List<string> getCargos()
    {
        return this.cargos;
    }
    public void setCargos(string x)
    {
        this.cargos.Add(x);
    }
    public void ImportaCargo(string caminhoSugestoesCargos)
    {
        if (!File.Exists(caminhoSugestoesCargos))
        {
            StreamWriter sw = new StreamWriter(caminhoSugestoesCargos);
            //sw.WriteLine();
            sw.Close();
        }
        else
        {
            StreamReader sr = new StreamReader(caminhoSugestoesCargos);
            string linha = sr.ReadLine();
            while (linha != null)
            {
                this.cargos.Add(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }
    }    
}