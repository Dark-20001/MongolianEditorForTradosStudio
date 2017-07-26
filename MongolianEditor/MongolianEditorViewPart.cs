using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace MongolianEditor
{
     [ViewPart(
        Id = "MongolianEditor",
        Icon = "HT",
        Name = "Mongolian Editer",
        Description = "Editor for Mongolian")]
     [ViewPartLayout(typeof(EditorController), Dock = DockType.Right)]
    class MongolianEditorViewPart : AbstractViewPartController
    {
        protected override System.Windows.Forms.Control GetContentControl()
        {
            return _control.Value;
        }

        protected override void Initialize()
        {
        }
       
        private readonly Lazy<MongolianEditorControl> _control = new Lazy<MongolianEditorControl>(() => new MongolianEditorControl());
    }
}
