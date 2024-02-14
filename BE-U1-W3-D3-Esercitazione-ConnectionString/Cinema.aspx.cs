using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace BE_U1_W3_D3_Esercitazione_ConnectionString
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Logica di caricamento della pagina (se necessario)
        }

        protected void ButtonAcquista_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            string cognome = TextBoxCognome.Text;
            string sala = DropDownListSala.SelectedValue;
            bool bigliettoRidotto = CheckBoxBigliettoRidotto.Checked;

            try
            {
                InserisciBigliettoDB(nome, cognome, sala, bigliettoRidotto);
                // Aggiorna altri elementi se necessario
            }
            catch (Exception ex)
            {
                // Gestisci eventuali errori
                // Esempio: mostra un messaggio di errore o registra l'errore nei log
                Response.Write($"Si è verificato un errore: {ex.Message}");
            }
        }

        public void InserisciBigliettoDB(string nome, string cognome, string sala, bool bigliettoRidotto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);


                try
            {
                conn.Open();

                string query = "INSERT INTO Prenotazioni (Nome, Cognome, Sala, Ridotto) VALUES (@Nome, @Cognome, @Sala, @Ridotto)";

                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Cognome", cognome);
                cmd.Parameters.AddWithValue("@Sala", sala);
                cmd.Parameters.AddWithValue("@Ridotto", bigliettoRidotto);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write($"Si è verificato un errore: {ex.Message}");
            }
            finally 
            {
                conn.Close(); 
            }

        }
    }
}
