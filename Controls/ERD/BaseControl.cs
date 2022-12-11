﻿using DoQL.Interfaces;

namespace DoQL.Controls.ERD
{
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
            _connectors = new List<ConnectorControl>();
        }

        #region dragging

        private Point _point;
        private bool _selected;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Parent.Controls.SetChildIndex(this, 0);
            _selected = true;
            _point = e.Location;
            HideConnectors();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _selected = false;
            ShowConnectors();
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_selected)
            {
                SuspendLayout();
                Left += e.X - _point.X;
                Top += e.Y - _point.Y;
                ResumeLayout();
                (Parent as DiagramPanel).RedrawCardinalities();
            }
            base.OnMouseMove(e);
        }

        #endregion

        # region connectors

        private readonly List<ConnectorControl> _connectors;

        protected override void OnMouseEnter(EventArgs e)
        {
            ShowConnectors();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            HideConnectors();
            base.OnMouseLeave(e);
        }

        public void ShowConnectors()
        {
            if (this is IConnectable connectable)
            {
                Point[] availableConnectors = connectable.GetConnectablePoints();
                for (int i = 0; i < availableConnectors.Length; i++)
                {
                    Point point = availableConnectors[i];
                    point.Offset(Location);
                    var connector = new ConnectorControl(connectable, i);
                    point.Offset(-connector.Width / 2, -connector.Height / 2);
                    connector.Location = point;
                    _connectors.Add(connector);
                    Parent.Controls.Add(connector);
                    Parent.Controls.SetChildIndex(connector, 0);
                }
            }
        }

        public void HideConnectors(bool force = false)
        {
            if (!force)
            {
                foreach (ConnectorControl connector in _connectors)
                {
                    if (IsMouseOverControl(connector))
                        return;
                }
            }
            foreach (ConnectorControl connector in _connectors)
            {
                Parent.Controls.Remove(connector);
            }
            _connectors.Clear();
        }

        private static bool IsMouseOverControl(Control control) => control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));

        #endregion
    }
}
