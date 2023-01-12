using System;

public class Conta {

    private Boolean status;
    private string nomeCompleto;
    private string email;
    private string cargo;
    private string nomeUsuario;
    private string senha;
    private string palavraPasse;
    


    public Conta() {

        this.status = true;
        this.nomeCompleto = "N/A";
        this.email = "N/A";
        this.cargo = "N/A";
        this.nomeUsuario = "N/A";
        this.senha = "N/A";
        this.palavraPasse = "N/A";
    }

    public Boolean Status {
        get { return this.status;}
        set { this.status = value; }
    }
    public string NomeCompleto {
        get { return this.nomeCompleto;}
        set { this.nomeCompleto = value;}
    }

    public string Email {
        get { return this.email;}
        set {this.email = value;}
    }

    public string Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public string NomeUsuario {
        get { return this.nomeUsuario;}
        set {this.nomeUsuario = value;}
    }

    public string Senha {
        get { return this.senha;}
        set {this.senha = value;}
    }    

    public string PalavraPasse
    {
        get { return this.palavraPasse; }
        set { this.palavraPasse = value; }
    }
}