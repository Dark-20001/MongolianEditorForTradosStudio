using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MongolianEditer
{
    public partial class MongolianEditerControl : UserControl
    {
        private Document _document;
        private EditorController _editorController=SdlTradosStudio.Application.GetController<EditorController>();

        public MongolianEditerControl()
        {
            InitializeComponent();
        }

        private void _document_ActiveSegmentChanged(object sender, EventArgs e)
        {
            if (_document.ActiveSegmentPair.Target!=null)
                textBoxEditor.Text = _document.ActiveSegmentPair.Target.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _document = _editorController.ActiveDocument;
            if (_document == null)
            {
                MessageBox.Show("There is no document loaded in the editor");
            }
            else
            {
                if (checkBoxSwitch.Checked)
                {
                    _document.ActiveSegmentChanged += new EventHandler(_document_ActiveSegmentChanged);
                }
                else
                {
                    _document.ActiveSegmentChanged -= new EventHandler(_document_ActiveSegmentChanged);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_document == null)
            {
                MessageBox.Show("There is no document loaded in the editor or EventHandler not Started!");
            }
            else
            {
                var segmentPair = _editorController.ActiveDocument.ActiveSegmentPair;
                bool isFirst = true;
                foreach (IAbstractMarkupData markupData in segmentPair.Target)
                {
                    var text = markupData as IText;
                    if (text != null)
                    {
                        if (isFirst)
                        {
                            text.Properties.Text = textBoxEditor.Text;
                        }
                        else
                        {
                            text.Properties.Text = string.Empty;
                        }
                        isFirst = false;
                    }
                }               

                _document.UpdateSegmentPair(segmentPair);

                

            }
        }
    }
}
