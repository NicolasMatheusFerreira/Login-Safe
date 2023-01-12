using System;
using System.IO;
using System.Collections.Generic;

class Config {

    public List<string> cargo = new List<string>();
    private string usuarioAdministrador;
    private string senhaAdministrador;
    private string senhaAdministradorCadastro;    

    public Config() {

        ImportarCargo("cargos.txt");
        this.usuarioAdministrador = "Admin123";
        this.senhaAdministrador = "Admin123";        
        this.senhaAdministradorCadastro = "Admin";
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
    public void ImportarCargo(string caminho)
    {        
        StreamReader sr = new StreamReader(caminho);
        string linha = sr.ReadLine();
        while(linha!=null)
        {
            cargo.Add(linha);
            linha = sr.ReadLine();                       
        }
        sr.Close();        
    }
}