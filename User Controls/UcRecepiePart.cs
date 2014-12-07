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
    public partial class UcRecepiePart : UserControl
    {
        Point _ingredientLocation = new Point(0, 23);

        #region Properties
        public int IdRecepieHeading { get; set; }
        public int IdRecepie { get; set; }
        public int SortOrder { get; set; }
        public string RecepiePartName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public List<UcRecepieIngredient> Ingredients { get; set; }
        #endregion

        #region Events
        public event EventHandler IngredientsChangedEvent;

        protected virtual void IngredientsChanged(EventArgs e)
        {
            EventHandler handler = IngredientsChangedEvent;
            if (handler != null)
                handler(this, e);
        }
        #endregion

        public UcRecepiePart()
        {
            InitializeComponent();
            
        }

        public void GetRecepieIngredients()
        {
            Height = 23;
            Ingredients = new List<UcRecepieIngredient>();
            _ingredientLocation.Y = 23;
            string sql = "SELECT idIngredient, SortOrder " +
                         "FROM tblRecepieIngredients " +
                         "WHERE idRecepieHeading=" + IdRecepieHeading +
                         " ORDER BY SortOrder";
            DataTable tbl = Functions.GetTable(sql);
            foreach (DataRow row in tbl.Rows)
            {
                UcRecepieIngredient ingredient = new UcRecepieIngredient();
                ingredient.IdIngredient = (int)row["idIngredient"];
                ingredient.GetIngredient();
                ingredient.SortOrder = (int) row["SortOrder"];
                ingredient.Location = _ingredientLocation;
                ingredient.IngredientDeletedEvent += IngredientDeleted;
                Controls.Add(ingredient);
                Ingredients.Add(ingredient);
                _ingredientLocation.Y += 23;
                Height += 23;
            }
        }

        private void IngredientAdded(object sender, EventArgs e)
        {
            FrmEditRecepieIngredients frm = (FrmEditRecepieIngredients) sender;
            UcRecepieIngredient ingredient = frm.NewIngredient;
            ingredient.Location = _ingredientLocation;
            ingredient.IngredientDeletedEvent += IngredientDeleted;
            Controls.Add(ingredient);
            Ingredients.Add(ingredient);
            _ingredientLocation.Y += 23;
            Height += 23;
            IngredientsChanged(EventArgs.Empty);
        }

        private void IngredientDeleted(object sender, EventArgs e)
        {
            _ingredientLocation.Y += 23;
            Height += 23;
            UcRecepieIngredient ingredient = (UcRecepieIngredient) sender;
            Ingredients.Remove(ingredient);
            Controls.Remove(ingredient);
            ReorderIngredients();
            IngredientsChanged(EventArgs.Empty);
        }

        private void ReorderIngredients()
        {
            Height = 23;
            _ingredientLocation.Y = 23;
            int n = 1;
            foreach (Control cntrl in Controls)
            {
                if(cntrl.GetType()==typeof(UcRecepieIngredient))
                    Controls.Remove(cntrl);
            }

            foreach (UcRecepieIngredient ingredient in Ingredients)
            {
                ingredient.Location = _ingredientLocation;
                ingredient.SortOrder = n;
                ingredient.SetSortOrder();
                Controls.Add(ingredient);
                n += 1;
                _ingredientLocation.Y += 23;
                Height += 23;
            }

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FrmEditRecepieIngredients frm = new FrmEditRecepieIngredients();
            frm.IdRecepieHeading = IdRecepieHeading;
            frm.NewSortOrder = Ingredients.Count + 1;
            frm.IngredientAddEvent += IngredientAdded;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
