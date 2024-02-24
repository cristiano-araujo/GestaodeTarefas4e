using GestaodeTarefas4e.DAO;
using System;
using System.Web.UI;
using System.Windows.Forms.DataVisualization.Charting;

namespace TarefaS4e
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string titulo = title.Text;
            string descricao = description.Text;
            string dataInicio = startDate.Text;

            // Aqui você pode adicionar o código para salvar esses valores no banco de dados
            // ...

                   }
    }
}
