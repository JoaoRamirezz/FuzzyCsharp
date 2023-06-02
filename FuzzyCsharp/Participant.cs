public class Participant{
    public string Nome { get; set; }
    public int Formacao { get; set; }
    public int Idade { get; set; }

    public void participant(string nome, int formacao, int idade){
        this.Nome = nome;
        this.Formacao = formacao;
        this.Idade = idade;
    }
}