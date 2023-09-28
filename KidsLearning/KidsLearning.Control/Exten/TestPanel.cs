using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Control.Exten
{
public partial    class TestPanel : UserControlPrint
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "TestPanel";
            this.Size = new System.Drawing.Size(723, 544);
            this.ResumeLayout(false);

        }

        #region _ScoreChange
        private static readonly object _ScoreChange = new object();
        public event ScoreEventHandler ScoreChange
        {
            add
            {
                this.Events.AddHandler(_ScoreChange, value);
            }
            remove
            {
                this.Events.RemoveHandler(_ScoreChange, value);
            }
        }
        protected virtual void OnScoreChange(ScoreEvent e)
        {
            ScoreEventHandler handler = (ScoreEventHandler)Events[_ScoreChange];
            if (handler != null) handler(this, e);
        }

        private static readonly object _buttonChoie_Click = new object();
        public event EventHandler buttonChoieClick
        {
            add
            {
                this.Events.AddHandler(_buttonChoie_Click, value);
            }
            remove
            {
                this.Events.RemoveHandler(_buttonChoie_Click, value);
            }
        }
        protected virtual void OnbuttonChoieClick(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[_buttonChoie_Click];
            if (handler != null) handler(this, e);
        }
        #endregion
    }
}
