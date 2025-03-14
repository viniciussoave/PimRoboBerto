using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormRegistrar : Form
    {

        private bool _estaTrocandoTela = false;

        public FormRegistrar()
        {
            InitializeComponent();
            textBoxUsuario.KeyPress += textBox_KeyPress;
            textBoxSenha.KeyPress += textBox_KeyPress;
            textBoxConfirmarSenha.KeyPress += textBox_KeyPress;
            textBoxEmail.KeyPress += textBox_KeyPress;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede que o usuário pressione Enter para criar uma nova linha
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Ignora a tecla Enter e o espaço
            }
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        static bool ContemDigitoEspecialOuNumero(string senha)
        {
            // Expressão regular para verificar dígitos especiais ou números
            string padrao = @"[\d\W]";
            return Regex.IsMatch(senha, padrao);
        }


        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            FormInicio Inicio = new FormInicio();
            Inicio.StartPosition = FormStartPosition.Manual;
            Inicio.Location = this.Location;
            Inicio.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Verificar se todos os campos estão preenchidos
            if (textBoxUsuario.Text.Length == 0 || textBoxSenha.Text.Length == 0 || textBoxConfirmarSenha.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Erro: Preencha todos os campos!");
            } else
            {
                if(textBoxUsuario.Text.Length < 5 || textBoxUsuario.Text.Length > 20)
                {
                    //Verificar a quantidade de caracteres do usuario
                    MessageBox.Show("Erro: O usuario tem que ter pelo menos 5 caracteres e no maximo 20 caracteres!");
                }
                else
                {
                    //Aqui vai ser feito uma verificação no DB se o usuario já esta em uso
                    if (textBoxUsuario.Text == "teste")
                    {
                        MessageBox.Show("Erro: Usuario já esta em uso!");
                    }
                    else
                    {
                        //Verifica se na senha tem numeros e simbolos.
                        if (!ContemDigitoEspecialOuNumero(textBoxSenha.Text)){
                            MessageBox.Show("Erro: A senha deve conter números e símbolos.");
                        }
                        else
                        {
                            //Verificar a quantidade de caracteres da senha
                            if (textBoxSenha.Text.Length < 5 || textBoxSenha.Text.Length > 20)
                            {
                                MessageBox.Show("Erro: A senha tem que ter pelo menos 5 caracteres e no maximo 20 caracteres!");
                            }
                            else
                            {
                                //Verificar se as duas senhas estão iguais
                                if (textBoxSenha.Text != textBoxConfirmarSenha.Text)
                                {
                                    MessageBox.Show("Erro: As senhas não coincidem!");
                                }
                                else
                                {
                                    //Verifica se o e-mail é valido
                                    if (!IsValidEmail(textBoxEmail.Text))
                                    {
                                        MessageBox.Show("Erro: Insira um e-mail valido!");
                                    }
                                    else
                                    {
                                        //Verificar se o e-mail já esta em uso
                                        if (textBoxEmail.Text == "vini.bico@hotmail.com") 
                                        {
                                            MessageBox.Show("Erro: Email já esta em uso!");
                                        }
                                        else
                                        {
                                            //Deu tudo certo
                                            _estaTrocandoTela = true;
                                            this.Close();
                                            MessageBox.Show("Conta criada com sucesso!");
                                            FormInicio Inicio = new FormInicio();
                                            Inicio.StartPosition = FormStartPosition.Manual;
                                            Inicio.Location = this.Location;
                                            Inicio.Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            


            
                }
            }
        }
    

