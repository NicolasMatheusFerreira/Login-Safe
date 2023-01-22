using System;
using System.Collections.Generic;
using System.IO;

public class Login
{
    Celula inicio;
    private string caminho = "users.txt";
    private Conta sessao;

    public Login()
    {
        inicio = null;
        ImportaCadastro(caminho);
    }

    public Conta Sessao
    {
        get { return this.sessao; }
        set { this.sessao = value; }
    }    

    public Queue<Conta> GetListar()
    {
        Celula aux = inicio;
        Queue<Conta> obj = new Queue<Conta>();

        while(aux!=null)
        {
            obj.Enqueue(aux.atual);
            aux = aux.prox;
        }
        return obj;
    }

    public string SugereSenha()
    {
        Random aleatorio = new Random();
        int tamSenha = aleatorio.Next(7, 16);
        int opcao, sugestao;
        string senha = "";
        bool parada = true;

        for (int i = 1; i <= tamSenha; i++)
        {
            opcao = aleatorio.Next(0, 4);

            parada = true;
            switch (opcao)
            {
                case 1: // Caracter especial
                    while (parada)
                    {
                        sugestao = aleatorio.Next(33, 255);
                        if (sugestao >= 33 && sugestao <= 47 || sugestao >= 58 && sugestao <= 64 || sugestao >= 91 && sugestao <= 96)
                        {
                            senha = senha + Convert.ToChar(sugestao);
                            parada = false;
                        }
                    }

                    break;

                case 2: // Número
                    while (parada)
                    {
                        sugestao = aleatorio.Next(33, 255);
                        if (sugestao >= 48 && sugestao <= 57)
                        {
                            senha = senha + Convert.ToChar(sugestao);
                            parada = false;
                        }
                    }
                    break;

                case 3: // Letra                    
                    while (parada)
                    {
                        sugestao = aleatorio.Next(33, 255);
                        if (sugestao >= 97 && sugestao <= 122 || sugestao >= 65 && sugestao <= 90)
                        {
                            senha = senha + Convert.ToChar(sugestao);
                            parada = false;
                        }
                    }
                    break;
            }
        }
        return senha;
    }

    public bool CheckEspacosBrancos(string senha)
    {
        for (int i = 0; i < senha.Length; i++)
        {
            if (senha[i] == ' ')
                return true;
        }
        return false;
    }

    public bool CheckMaiuscula(string senha)
    {
        for (int i = 0; i < senha.Length; i++)
            if (senha[i] > 65 && senha[i] < 90)
                return true;
        return false;
    }
    public bool CheckCaracterEspecial(string senha)
    {
        for (int i = 0; i < senha.Length; i++)
            if (senha[i] >= 33 && senha[i] <= 47 || senha[i] >= 58 && senha[i] <= 64 || senha[i] >= 91 && senha[i] <= 96 || senha[i] >= 123 && senha[i] < 243)
                return true;
        return false;
    }
    public bool CheckNumeros(string senha)
    {
        for (int i = 0; i < senha.Length; i++)
            if (senha[i] >= '0' && senha[i] <= '9')
                return true;
        return false;
    }
    public bool CheckLetras(string senha)
    {
        for (int i = 0; i < senha.Length; i++)
            if (senha[i] >= 'a' && senha[i] <= 'z' || senha[i] >= 'A' && senha[i] <= 'Z')
                return true;
        return false;
    }

    public int CheckSenha(string senha)
    {
        if (senha.Length > 8 && CheckLetras(senha) && CheckNumeros(senha) && CheckCaracterEspecial(senha) && CheckMaiuscula(senha))
            return 3;
        else if (senha.Length > 8 && CheckLetras(senha) && CheckNumeros(senha) && CheckCaracterEspecial(senha))
            return 2;
        if (senha.Length > 8 && CheckLetras(senha))
            return 1;
        else return 0;
    }

    public bool Entra(string nomeUsuario, string senha, string cargo)
    {

        Celula aux = inicio;
        while (aux != null)
        {
            if (aux.atual.Status == true && nomeUsuario.Equals(aux.atual.NomeUsuario) && senha.Equals(aux.atual.Senha) && cargo.Equals(aux.atual.Cargo))
            {
                Sessao = aux.atual;

                aux.atual.AcessosSystem = Sessao.NomeCompleto + " " + Sessao.NomeUsuario;

                return true;
            }
            aux = aux.prox;
        }
        return false;
    }
    public bool RegistrosDuplicados(Conta obj)
    {
        Celula aux = inicio;
        while (aux != null)
        {
            if (obj.NomeUsuario.Equals(aux.atual.NomeUsuario))
                return true;
            aux = aux.prox;
        }
        return false;
    }

    public Conta Pop(string nomeUsuario)
    {

        Celula aux = inicio;
        Conta j = new Conta();
        if (inicio != null)
        {
            if (nomeUsuario.Equals(aux.atual.NomeUsuario))
            {
                j = aux.atual;
                aux = aux.prox;
                inicio = aux;
            }
            else
            {
                while (aux.prox != null)
                {
                    Celula aux2 = new Celula();
                    if (nomeUsuario.Equals(aux.prox.atual.NomeUsuario))
                    {
                        aux2 = aux.prox.prox;
                        j = aux.prox.atual;
                        aux.prox = aux2;
                        return j;
                    }
                    aux = aux.prox;
                }
                Console.WriteLine("Registro nao encontrado!");
            }
        }
        else Console.WriteLine("Registro nao encontrado!");
        return j;
    }

    public Conta RemoverCadastro(string nomeUsuario)
    {
        Conta aux = Pop(nomeUsuario);
        ExportaCadastro(caminho, false);
        return aux;
    }
    public Conta FormatoLeitura(string conteudo)
    {

        Conta aux = new Conta();
        string[] formatoLeitura = new string[8];
        int j = 0;

        for (int i = 0; i < conteudo.Length; i++)
        {
            if (conteudo[i] == '|')
                j++;
            else formatoLeitura[j] += conteudo[i];
        }
        aux.Status = Convert.ToBoolean(formatoLeitura[0]);
        aux.NomeCompleto = formatoLeitura[1];
        aux.Email = formatoLeitura[2];
        aux.Cargo = formatoLeitura[3];
        aux.NomeUsuario = formatoLeitura[4];
        aux.Senha = formatoLeitura[5];
        aux.PalavraPasse = formatoLeitura[6];
        aux.AcessosSystem = formatoLeitura[7];

        return aux;
    }
    public void ImportaCadastro(string caminhoPath)
    {

        if (!File.Exists(caminhoPath))
        {
            Console.WriteLine("Erro! Diretorio inexistente!");
        }
        else
        {
            StreamReader sr = new StreamReader(caminhoPath);
            string linha = "";
            linha = sr.ReadLine();
            while (linha != null)
            {
                Push(FormatoLeitura(linha));
                linha = sr.ReadLine();
            }
            sr.Close();

            if (!caminho.Equals(caminhoPath))
                ExportaCadastro(caminho, false);
        }
    }
    public void FormatoCadastro(Celula aux, StreamWriter sw)
    {

        sw.WriteLine(aux.atual.Status + "|" + aux.atual.NomeCompleto + "|" + aux.atual.Email + "|" + aux.atual.Cargo + "|" + aux.atual.NomeUsuario + "|" + aux.atual.Senha + "|" + aux.atual.PalavraPasse + "|" + aux.atual.AcessosSystem);
    }
    public void ExportaCadastro(string caminho, bool permissao)
    {

        StreamWriter sw = new StreamWriter(caminho, permissao);
        if (inicio != null)
        {
            Celula aux = inicio;
            while (aux != null)
            {
                FormatoCadastro(aux, sw);
                aux = aux.prox;
            }
            sw.Close();
        }
    }
    public bool ValidaSenha(string x, string aux)
    {
        if (x.Equals(aux))
            return true;
        return false;
    }
    public void Push(Conta obj)
    {
        if (inicio == null)
        {
            inicio = new Celula();
            inicio.atual = obj;
            inicio.prox = null;
        }
        else
        {
            Celula aux = new Celula();
            aux.atual = obj;
            aux.prox = inicio;
            inicio = aux;
        }
    }
    public bool Cadastra(Conta conta)
    {

        Push(conta);
        ExportaCadastro(caminho, false);
        return true;
    }
}