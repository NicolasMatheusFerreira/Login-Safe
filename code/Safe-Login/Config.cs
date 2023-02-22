using System;
using System.IO;
using System.Collections.Generic;

public class Config
{
    Login login;
    Admin admin;
    
    public List<string> cargo = new List<string>();
    public List<string> nomesUsuario = new List<string>();   

    private string caminhoAcessosSystemLogs;

    public Config(Login login, Admin admin)
    {
        this.login = login;
        this.admin = admin;

        ImportaCargo("cargos.txt");
        ImportaSugestoesUsuario("sugestoesNomesUsuarios.txt");


        this.caminhoAcessosSystemLogs = "acessosSystem.log";         
    }
   
    public void ExportaConfiguracoes()
    {
        admin.ExportaAdmin();
    }

    public void SetAcessosSystemLogs(string x)
    {
        if (!File.Exists(x))
        {
            StreamWriter sw = new StreamWriter(caminhoAcessosSystemLogs, true);
            sw.WriteLine("# Software: Safe-Login");
            sw.WriteLine("# Versão: 0.0.1");
            sw.WriteLine("# Propriedade: \n");
            sw.WriteLine(DateTime.Now + "----- [" + x + "]");
            sw.Close();
        }
        else
        {
            StreamWriter sw = new StreamWriter(caminhoAcessosSystemLogs, true);
            sw.WriteLine(DateTime.Now + "----- [" + x + "]");
            sw.Close();
        }
    }

    public void ImportaSugestoesUsuario(string caminhoSugestoesUsuario)
    {
        StreamReader sr = new StreamReader(caminhoSugestoesUsuario);
        string linha = sr.ReadLine();
        while (linha != null)
        {
            nomesUsuario.Add(linha);
            linha = sr.ReadLine();
        }
        sr.Close();
    }
    public void ImportaCargo(string caminhoSugestoesCargos)
    {
        StreamReader sr = new StreamReader(caminhoSugestoesCargos);
        string linha = sr.ReadLine();
        while (linha != null)
        {
            cargo.Add(linha);
            linha = sr.ReadLine();
        }
        sr.Close();
    }
}