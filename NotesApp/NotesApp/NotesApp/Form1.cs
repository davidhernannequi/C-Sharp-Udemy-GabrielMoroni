using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        List<Note> _notes = new List<Note>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && 
                !string.IsNullOrEmpty(txtNotes.Text))
            {
                var note = new Note();

                note.Title = txtTitle.Text;
                note.Notes = txtNotes.Text;

                _notes.Add(note);

                PopulateNotes();

                ClearForm();
            }

        }

        private void PopulateNotes ()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _notes;
            dgvNotes.DataSource = bs;
        }

        private void ClearForm ()
        {
            txtNotes.Text = string.Empty;
            txtTitle.Text = string.Empty;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            if (dgvNotes.SelectedRows != null)
            {
                var title = dgvNotes.SelectedCells[0].Value.ToString();
                var notes = GetNotesByTitle(title);


                txtTitle.Text = title;
                txtNotes.Text = notes;
            }
        }

        private string GetNotesByTitle (string title)
        {
            var notes = string.Empty;

            foreach (var note in _notes)
            {
                if (note.Title == title)
                    notes = note.Notes;
            }
            return notes;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows != null)
            {
                var title = dgvNotes.SelectedCells[0].Value.ToString();
                var notes = DeleteByTitle(title);
                PopulateNotes();
            }
        }

        private string DeleteByTitle (string title)
        {
            Note noteToRemove = null;

            foreach (var note in _notes)
            {
                if (note.Title == title)
                    noteToRemove = note;
            }

            if (noteToRemove != null)
                _notes.Remove(noteToRemove);

            return title;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
