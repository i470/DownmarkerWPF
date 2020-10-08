using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;

namespace MarkPad.Core.Document.Controls
{
    internal sealed class UITextBlockAutomationPeer : AutomationPeer
    {
        private UITextBlock uITextBlock;

        public UITextBlockAutomationPeer(UITextBlock uITextBlock)
        {
            this.uITextBlock = uITextBlock;
        }

        public override object GetPattern(PatternInterface patternInterface)
        {
            throw new System.NotImplementedException();
        }

        protected override string GetAcceleratorKeyCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetAccessKeyCore()
        {
            throw new System.NotImplementedException();
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetAutomationIdCore()
        {
            throw new System.NotImplementedException();
        }

        protected override Rect GetBoundingRectangleCore()
        {
            throw new System.NotImplementedException();
        }

        protected override List<AutomationPeer> GetChildrenCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetClassNameCore()
        {
            throw new System.NotImplementedException();
        }

        protected override Point GetClickablePointCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetHelpTextCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetItemStatusCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetItemTypeCore()
        {
            throw new System.NotImplementedException();
        }

        protected override AutomationPeer GetLabeledByCore()
        {
            throw new System.NotImplementedException();
        }

        protected override string GetNameCore()
        {
            throw new System.NotImplementedException();
        }

        protected override AutomationOrientation GetOrientationCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool HasKeyboardFocusCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsContentElementCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsControlElementCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsEnabledCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsKeyboardFocusableCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsOffscreenCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsPasswordCore()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsRequiredForFormCore()
        {
            throw new System.NotImplementedException();
        }

        protected override void SetFocusCore()
        {
            throw new System.NotImplementedException();
        }
    }
}