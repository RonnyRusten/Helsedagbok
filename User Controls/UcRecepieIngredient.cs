using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helsedagbok.User_Controls
{
    public partial class UcRecepieIngredient : UserControl
    {
        #region Properties
        public int IdIngredient { get; set; }
        public int IdRecepieHeading { get; set; }
        public int IdFood { get; set; }
        public int IdUnit { get; set; }
        public int SortOrder { get; set; }
        #endregion

        #region Events
        public event EventHandler IngredientDeletedEvent;
        public event EventHandler IngredientUpdatedEvent;

        protected virtual void IngredientDeleted(EventArgs e)
        {
            EventHandler handler = IngredientDeletedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void IngredientUpdated(EventArgs e)
        {
            EventHandler handler = IngredientUpdatedEvent;
            if (handler != null)
                handler(this, e);
        }
        #endregion

        public UcRecepieIngredient()
        {
            InitializeComponent();
        }

        public void GetIngredient()
        {
           Height = 23;
           string sql = "SELECT tblRecepieIngredients.idFood, " +
                        "tblMatvarer.Name, " +
                        "tblRecepieIngredients.Amount, " +
                        "tblRecepieIngredients.idUnit, " +
                        "tblUnits.Name, " +
                        "tblRecepieIngredients.idRecepieHeading, " +
                        "tblRecepieIngredients.SortOrder " +
                        "FROM tblRecepieIngredients " +
                        "JOIN tblMatvarer ON tblMatvarer.id=idFood " +
                        "JOIN tblUnits ON tblUnits.id=idUnit " +
                        "WHERE tblRecepieIngredients.idIngredient=" + IdIngredient +
                        " ORDER BY tblRecepieIngredients.SortOrder";
            DataTable tbl = Functions.GetTable(sql);
            lblAntall.Text = String.Format("{0:#.##}", tbl.Rows[0]["Amount"]);
            lblUnit.Text = tbl.Rows[0]["Name1"].ToString();
            lblIngredient.Text = tbl.Rows[0]["Name"].ToString();
            IdFood = (int) tbl.Rows[0]["idFood"];
            IdUnit = (int) tbl.Rows[0]["idUnit"];
            IdRecepieHeading = (int) tbl.Rows[0]["idRecepieHeading"];
            SortOrder = (int) tbl.Rows[0]["SortOrder"];
        }

        public void SetSortOrder()
        {
            string sql = "UPDATE tblRecepieIngredients SET SortOrder=" + SortOrder + " WHERE idIngredient=" + IdIngredient;
            Functions.RunSql(sql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditRecepieIngredients frm = new FrmEditRecepieIngredients();
            frm.EditMode = true;
            frm.IdRecepieHeading = IdRecepieHeading;
            frm.IdIngredient = IdIngredient;
            frm.IdFood = IdFood;
            frm.IdUnit = IdUnit;
            frm.Amount = Convert.ToDecimal(lblAntall.Text);
            frm.IngredientUpdateEvent += IngredientUpdated;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tblRecepieIngredients where idIngredient=" + IdIngredient;
            if (Functions.RunSql(sql))
            {
                IngredientDeleted(EventArgs.Empty);
            }
        }

        private void IngredientUpdated(object sender, EventArgs e)
        {
            GetIngredient();
        }
    }
}
