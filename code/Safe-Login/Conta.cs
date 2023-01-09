using System;
public class Conta {

    private string nomeCompleto;
    private string email;
    private string nomeUsuario;
    private string senha;
    private string cargo;


    public Conta() {

        this.nomeCompleto = "N/A";
        this.email = "N/A";
        this.nomeUsuario = "N/A";
        this.senha = "N/A";
        this.cargo = "N/A";
    }

    public string NomeCompleto {
        get { return this.nomeCompleto;}
        set { this.nomeCompleto = value;}
    }

    public string Email {
        get { return this.email;}
        set {this.email = value;}
    }

    public string NomeUsuario {
        get { return this.nomeUsuario;}
        set {this.nomeUsuario = value;}
    }

    public string Senha {
        get { return this.senha;}
        set {this.senha = value;}
    }

    public string Cargo {
        get {return this.cargo;}
        set {this.cargo = value;}
    }
}