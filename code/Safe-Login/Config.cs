using System;
using System.IO;
using System.Collections.Generic;

class Config {

    public List<string> cargo = new List<string>();
    public List<string> nomesUsuario = new List<string>();

    private string usuarioAdministrador;
    private string senhaAdministrador;
    private string senhaAdministradorCadastro;

    private string caminhoAcessosSystemLogs;

    public Config() {

        ImportaCargo("cargos.txt");
        ImportaSugestoesUsuario("sugestoesNomesUsuarios.txt");

        this.usuarioAdministrador = "Admin123";
        this.senhaAdministrador = "Admin123";        
        this.senhaAdministradorCadastro = "Admin";

        this.caminhoAcessosSystemLogs = "acessosSystem.log";
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
    public bool Admin(string usuario, string senha)
    {
        if (usuario.Equals(this.usuarioAdministrador) && senha.Equals(this.senhaAdministrador))
            return true;
        return false;
    }
    public string UsuarioAdministrador
    {
        get { return this.usuarioAdministrador; }
        set { this.usuarioAdministrador = value; }
    }
    public string SenhaAdminstrador
    {
        get { return this.senhaAdministrador; }
        set { this.senhaAdministrador = value; }
    }

    public bool AdminCadastro(string i)
    {
        return this.senhaAdministradorCadastro.Equals(i) ? true : false;
    }
    public string SenhaAdministradorCadastro
    {
        get { return this.senhaAdministradorCadastro; }
        set { this.senhaAdministradorCadastro = value; }
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
        while(linha!=null)
        {
            cargo.Add(linha);
            linha = sr.ReadLine();                       
        }
        sr.Close();        
    }
}