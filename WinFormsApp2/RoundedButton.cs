using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp2a
{
    public class RoundedButton : Button
    {
        // Raio das bordas (ajuste conforme necessário)
        public int CornerRadius { get; set; } = 15;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                // Cria um retângulo arredondado
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseAllFigures();

                // Define a região do botão para a área arredondada
                Region = new Region(path);

                // Preenche o fundo
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Desenha a borda
                using (Pen pen = new Pen(ForeColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Desenha o texto centralizado
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, sf);
            }
        }

        // Atualiza a região quando o tamanho muda
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }

}
