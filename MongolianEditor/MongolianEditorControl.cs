using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;
using Sdl.FileTypeSupport.Framework.BilingualApi;
using Sdl.FileTypeSupport.Framework.NativeApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Actions;

namespace MongolianEditor
{
    public partial class MongolianEditorControl : UserControl
    {
        private Document _document;
        private EditorController _editorController=SdlTradosStudio.Application.GetController<EditorController>();

        public MongolianEditorControl()
        {
            InitializeComponent();
        }

        private void _document_ActiveSegmentChanged(object sender, EventArgs e)
        {
            if (_document.ActiveSegmentPair.Target != null)
            {
                mnTextView1.Text = _document.ActiveSegmentPair.Target.ToString();
            }
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
                //useless
                //SegmentId _id = _document.ActiveSegmentPair.Properties.Id;

                //Way 1
                //if (_document.Selection.Current is SourceSelection)
                //{
                //    MessageBox.Show("The replace of a source selection is not available.");
                //    return;
                //}
                //SendKeys.SendWait("^({TAB})");
                //SendKeys.SendWait("^(A)");
                //SendKeys.SendWait("{DEL}");
                //_document.Selection.Target.Replace(textBox1.Text, "external Editor replacement");
                //_document.Selection.Target.Collapse();

                //Way 2
                var segmentPair = _editorController.ActiveDocument.ActiveSegmentPair;
                bool isFirst = true;
                foreach (IAbstractMarkupData markupData in segmentPair.Target)
                {
                    var text = markupData as IText;
                    if (text != null)
                    {
                        if (isFirst)
                        {
                            //text.Properties.Text = textBoxEditor.Text;
                            text.Properties.Text = mnTextView1.Text;
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

        private void MongolianEditorControl_Load(object sender, EventArgs e)
        {
            mnTextView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fdiag = new FontDialog();
            if (fdiag.ShowDialog() == DialogResult.OK)
            {
                mnTextView1.Font = fdiag.Font;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.mnTextView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                this.mnTextView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }
    }
}
