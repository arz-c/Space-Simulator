using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SpaceSimulator {
    public class RigidBody {
        #region Constants

        public const int TRAIL_QUEUE_CAPACITY = 50;

        #endregion

        #region Fields

        // ..with a corresponding property

        private string name = "Body";
        private Vector2 position = new Vector2(SpaceSimulatorForm.CENTER_X, SpaceSimulatorForm.CENTER_Y);
        private float radius = 20;
        private Color colour = Color.Green;

        private float mass = 100;
        private Vector2 velocity = new Vector2(50, 0);

        private List<RigidBody> environment;

        // ..without a corresponding property

        private float diameter;
        private Brush fillBrush;
        private Pen drawPen;

        private Vector2 acceleration;
        private Queue<PointF> trail = new Queue<PointF>(20);

        #endregion

        #region Properties

        public string Name { get => name; set => name = value; }
        public Vector2 Position { get => position; set {
                position = value;
                
                // Guaranteeing 2 points for g.DrawClosedCurve
                PointF pos = new PointF(position.X, position.Y);
                trail.Enqueue(pos);
                trail.Enqueue(pos);
            }
        }
        public float Radius { get => radius; set { radius = value; diameter = value * 2; } }
        public Color Colour { get => colour; set { colour = value; fillBrush = new SolidBrush(value);  drawPen = new Pen(value); } }

        public float Mass { get => mass; set => mass = value; }
        public Vector2 Velocity { get => velocity; set => velocity = value; }

        public List<RigidBody> Environment { get => environment; set => environment = value; }

        #endregion

        #region Methods

        public void Update(float deltaTime) {
            acceleration = Vector2.Zero;

            // Calculating net gravitational attraction from all bodies in 'environment'
            Vector2 gravField = Vector2.Zero;
            foreach(RigidBody rb in environment) {
                if(!rb.Equals(this)) {
                    gravField +=
                        SpaceSimulatorForm.G * rb.Mass
                        * (float) Math.Pow(Vector2.Distance(rb.Position, position), -2)
                        * Vector2.Normalize(rb.Position - position);
                }
            }
            acceleration += gravField;

            // Updating position vectors
            velocity += acceleration * deltaTime;
            position += velocity * deltaTime;
        }

        public void Draw(Graphics g) {
            g.FillEllipse(fillBrush, position.X - radius, position.Y - radius, diameter, diameter);
            
            PointF[] trailArray = trail.ToArray();
            foreach(PointF p in trail) {
                g.DrawCurve(drawPen, trailArray);
            }
        }

        public void PingTrail() {
            trail.Enqueue(new PointF(position.X, position.Y));
            if(trail.Count > TRAIL_QUEUE_CAPACITY) {
                trail.Dequeue();
            }
        }

        public void ClearTrail() {
            trail.Clear();

            // Guaranteeing 2 points for g.DrawClosedCurve
            PointF pos = new PointF(position.X, position.Y);
            trail.Enqueue(pos);
            trail.Enqueue(pos);
        }

        #endregion
    }
}
