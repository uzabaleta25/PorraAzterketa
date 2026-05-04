using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_5
{
    /// <summary>
    /// Represents a sweepstake (Porra) containing predictions and accumulated points.
    /// </summary>
    public class Porra
    {
        private string izena, irabazlea, finalista, goleatzailea;
        private int puntuak;

        /// <summary>
        /// Gets or sets the name of the participant or team.
        /// </summary>
        public string Izena { get => izena; set => izena = value; }

        /// <summary>
        /// Gets or sets the predicted winner.
        /// </summary>
        public string Irabazlea { get => irabazlea; set => irabazlea = value; }

        /// <summary>
        /// Gets or sets the predicted finalist or runner-up.
        /// </summary>
        public string Finalista { get => finalista; set => finalista = value; }

        /// <summary>
        /// Gets or sets the predicted goalscorer.
        /// </summary>
        public string Goleatzailea { get => goleatzailea; set => goleatzailea = value; }

        /// <summary>
        /// Gets or sets the accumulated points.
        /// </summary>
        public int Puntuak { get => puntuak; set => puntuak = value; }

        /// <summary>
        /// Initializes a new instance of the Porra class.
        /// </summary>
        /// <param name="i">The name of the participant.</param>
        /// <param name="ir">The predicted winner.</param>
        /// <param name="fi">The predicted finalist.</param>
        /// <param name="go">The predicted goalscorer.</param>
        /// <param name="p">The initial points.</param>
        public Porra(string i, string ir, string fi, string go, int p)
        {
            this.izena = i;
            this.irabazlea = ir;
            this.finalista = fi;
            this.goleatzailea = go;
            this.puntuak = p;
        }

        /// <summary>
        /// Returns a detailed string representation of the sweepstake predictions.
        /// </summary>
        /// <returns>A formatted string with all the sweepstake details.</returns>
        public string Pantailaratu()
        {
            return "TALDEA=" + izena + ", bere IRABAZLEA=" + irabazlea + ", beste FINALISTA=" + finalista + ", GOLEATZAILEA=" + goleatzailea + " eta PUNTUAK=" + puntuak;
        }

        /// <summary>
        /// Returns a simple string representation of the sweepstake.
        /// </summary>
        /// <returns>A string with properties separated by hyphens.</returns>
        public override string ToString()
        {
            return izena + "-" + irabazlea + "-" + finalista + "-" + goleatzailea + "-" + puntuak;
        }

        /// <summary>
        /// Calculates the points for correctly guessing the winner.
        /// </summary>
        /// <returns>The accumulated points plus 25 bonus points.</returns>
        public int AsmatuIrabazlea()
        {
            return (puntuak + 25);
        }

        /// <summary>
        /// Calculates the points for correctly guessing both finalists.
        /// </summary>
        /// <returns>The accumulated points plus 20 bonus points.</returns>
        public int AsmatuBiFinalistak()
        {
            return (puntuak + 20);
        }

        /// <summary>
        /// Calculates the points for a goal.
        /// </summary>
        /// <returns>The accumulated points plus 3 bonus points.</returns>
        public int Goleko()
        {
            return (puntuak + 3);
        }
    }
}