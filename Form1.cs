using BLL.ReprostoryImplementation;
using MODEL.Entity;
using MODEL.Enum;
using MODEL.Helpers;
using System;
using System.Windows.Forms;

namespace Katmanlı_Mimari_Tekrar
{

    public partial class Form1 : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void CategoryList()
        {
            lstKategoriler.Items.Clear();
            foreach (var item in _categoryRepository.SearchList(x => x.Status == Status.Active || x.Status == Status.Updated))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Description);
                lvi.Tag = item.Id;
                lstKategoriler.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                Name = txtKategoriAdi.Text,
                Description = txtAciklama.Text,
                Status = Status.Active
            };

            ResultModel<Category> result = _categoryRepository.Insert(category);
            if (result.IsSuccess)
            {
                
                txtAciklama.Text = string.Empty;
                txtKategoriAdi.Text = string.Empty;
                CategoryList();
            }
            MessageBox.Show(result.Message);

        }
    }
}
