using System;
using System.IO;
using System.Collections.Generic;

class Config {

    public List<string> cargo = new List<string>();

    public Config() {
        ImportarCargo("cargos.txt");
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