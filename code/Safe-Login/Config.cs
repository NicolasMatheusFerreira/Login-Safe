using System;
using System.IO;
using System.Collections.Generic;

class Config {

    public List<string> cargo = new List<string>();
    private string senhaAdministradorCadastro;

    public Config() {

        ImportarCargo("cargos.txt");
        this.senhaAdministradorCadastro = "Admin";
    }

    public string SenhaAdministradorCadastro
    {
        get { return this.senhaAdministradorCadastro; }
        set { this.senhaAdministradorCadastro = value; }
    }
    public bool AdminCadastro(string i)
    {
        return this.senhaAdministradorCadastro.Equals(i) ? true : false;
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