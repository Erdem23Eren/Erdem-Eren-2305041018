using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ERDEM
{
    public class E
    {
        static void Main(string[] args)
        {
            int width = 1000;
            int height = 1000;
            int Cellsize = 4;
            Point characterPosition;
            {
                characterPosition = new Point(width / 2 / Cellsize * Cellsize, height / 2 / Cellsize * Cellsize);
                
            }
            
             {
                case W:
                    if (characterPosition.Y - Cellsize >= 0)
                        characterPosition.Y -= Cellsize;
                    break;
                case A:
                    if (characterPosition.Y + Cellsize < height)
                        characterPosition.Y += Cellsize;
                    break;
                case S:
                    if (characterPosition.X - Cellsize >= 0)
                        characterPosition.X -= Cellsize;
                    break;
                case  D:
                    if (characterPosition.X + Cellsize < width)
                        characterPosition.X += Cellsize;
                    break;
            }
                  this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            
            Pen gridPen = new Pen(Color.LightGray);
            for (int x = 0; x <= MapWidth; x += ize)
            {
                g.DrawLine(gridPen, x, 0, x, MapHeight);
            }

            for (int y = 0; y <= height; y += size)
            {
                g.DrawLine(gridPen, 0, y, width, y);
            }

           
            Brush characterBrush = Brushes.Blue;
            g.FillEllipse(characterBrush, characterPosition.X + 5, characterPosition.Y + 5, size - 10, size - 10);
        }
        {
            import Program.cs;
            import Program.cs;

            EndPoint
        }
    }
}
        }
    }
}