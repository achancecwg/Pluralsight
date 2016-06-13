using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoLibraryWin
{
    public partial class PhotoForm : Form
    {
        public PhotoForm()
        {
            InitializeComponent();
        }

        private void PhotoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var photoId = int.Parse(txtPhotoID.Text);
            var desc = txtDescription.Text;
            var filename = txtFilename.Text;

            if (!File.Exists(filename))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PhotoData.InsertPhoto(photoId, desc, filename);
            MessageBox.Show("Photo has been saved to the database", "Photo Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var photoId = int.Parse(txtPhotoID2.Text);
            var photoData = PhotoData.SelectPhoto(photoId);

            lblDescription2.Text = photoData.Description;
            pbxPhoto.Image = Image.FromStream(new MemoryStream(photoData.Photo));
        }
    }
}
