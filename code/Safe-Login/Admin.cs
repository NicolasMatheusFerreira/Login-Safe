using System.IO;

public class Admin
{

    private string usuarioAdmin;
    private string senhaAdmin;

    private const string caminhoArquivo = ".admin.txt";

    public Admin()
    {
        ImportaAdmin();        
    }

    public string UsuarioAdmin
    {

        get { return this.usuarioAdmin; }
        set { this.usuarioAdmin = value; }
    }

    public string SenhaAdmin
    {

        get { return this.senhaAdmin; }
        set { senhaAdmin = value; }
    }

    public void ResetAdmin()
    {
        this.UsuarioAdmin = "Admin123";
        this.SenhaAdmin = "Admin123";
    }

    public void ImportaAdmin()
    {        
        if (!File.Exists(caminhoArquivo))
        {
            ResetAdmin();
        }
        else
        {
            StreamReader arquivo = new StreamReader(caminhoArquivo);
            while (!arquivo.EndOfStream)
            {
                UsuarioAdmin = arquivo.ReadLine();
                SenhaAdmin = arquivo.ReadLine();
            }            
        }
    }

    public void ExportaAdmin()
    {
        StreamWriter arquivo = new StreamWriter(caminhoArquivo);
        arquivo.WriteLine(UsuarioAdmin);
        arquivo.WriteLine(SenhaAdmin);
        arquivo.Close();
    }

    public bool EntraAdmin(string usuario, string senha)
    {
        if (usuario.Equals(this.usuarioAdmin) && senha.Equals(this.senhaAdmin))
            return true;
        return false;
    }
}
