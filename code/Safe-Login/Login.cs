using System;
using System.IO;

public class Login {

    Celula inicio;
    public static string caminho = "users.txt";
    public Login() {
        inicio = null;
        ImportaCadastro(caminho);
    }
    
    public void Listar() {        
        Celula aux = inicio;
        while(aux!=null) {
            Console.WriteLine(aux.atual.NomeCompleto+"|"+aux.atual.Email+"|"+aux.atual.NomeUsuario+"|"+aux.atual.Senha);
            aux = aux.prox;
        }
    }

    public bool Entra(string nomeUsuario, string senha) {

        if (nomeUsuario.Equals("Admin") && senha.Equals("Admin"))
            return true;
        else {
            Celula aux = inicio;
            while(aux!=null) {
                if (nomeUsuario.Equals(aux.atual.NomeUsuario) && (senha.Equals(aux.atual.Senha)))
                    return true;            
                aux = aux.prox;
            }
            return false;
        }        
    }

    public Conta Pop(string nomeUsuario) {

        Celula aux = inicio;   
        Conta j = new Conta(); 
        if (inicio!=null) {                        
            if (nomeUsuario.Equals(aux.atual.NomeUsuario)) {
                j = aux.atual;
                aux = aux.prox;                    
                inicio = aux;
            } else {
                while(aux.prox!=null) {
                    Celula aux2 = new Celula(); 
                    if (nomeUsuario.Equals(aux.prox.atual.NomeUsuario)) {
                        aux2 = aux.prox.prox;
                        j = aux.prox.atual;
                        aux.prox = aux2;                    
                        return j;                    
                    }
                    aux = aux.prox;
                }
                Console.WriteLine("Registro nao encontrado!");
            }               
        } else Console.WriteLine("Registro nao encontrado!");        
        return j;
    }    

    public Conta RemoverCadastro(string nomeUsuario) {
        Conta aux = Pop(nomeUsuario);
        ExportaCadastro(caminho, false);
        return aux;
    }
    public Conta FormatoLeitura(StreamReader sr) {
        Conta aux = new Conta();
        aux.NomeCompleto = sr.ReadLine();
        aux.Email = sr.ReadLine();
        aux.NomeUsuario = sr.ReadLine();
        aux.Senha = sr.ReadLine();
        aux.Cargo = sr.ReadLine();
        sr.ReadLine();
        return aux;
    }
    public void ImportaCadastro(string caminho) {

        if (!File.Exists(caminho)) {
            Console.WriteLine("Erro! Diretorio inexistente!");
        } else {
            StreamReader sr = new StreamReader(caminho);
            while(!sr.EndOfStream) {
                Push(FormatoLeitura(sr));
            }
            sr.Close();
        }
    }
    public void FormatoCadastro(Celula aux, StreamWriter sw) {

        sw.WriteLine(aux.atual.NomeCompleto);
        sw.WriteLine(aux.atual.Email);
        sw.WriteLine(aux.atual.NomeUsuario);
        sw.WriteLine(aux.atual.Senha);
        sw.WriteLine(aux.atual.Cargo);
        sw.WriteLine();
    }
    public void ExportaCadastro(string caminho, bool permissao) {

        StreamWriter sw = new StreamWriter(caminho, permissao);
        if (inicio!=null) {
            Celula aux = inicio;
            while(aux!=null) {
                FormatoCadastro(aux, sw);
                aux = aux.prox;
            }
            sw.Close();
        }
    }
    public bool ValidaSenha(string x, string aux) {
        if (x.Equals(aux))
            return true;
        return false;    
    }
    public void Push(Conta obj) {
        if (inicio==null) {
            inicio = new Celula();
            inicio.atual = obj;
            inicio.prox = null;             
        } else {
            Celula aux = new Celula();
            aux.atual = obj;
            aux.prox = inicio;
            inicio = aux;
        }
    }    
    public bool Cadastra(Conta conta) {
        
        Push(conta);
        ExportaCadastro(caminho, false);
        return true;
    }
}