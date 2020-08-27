using System;
using System.Collections.Generic;
using System.Text;

namespace ResistorLibrary
{
    public class Resistor
    {
        #region variable
        private List<BandColors> band;
        private MultiplierColor multiplier;
        private ToleranceColor trolerance;

        public MultiplierColor Multiplier { get { return this.multiplier; } set { this.multiplier = value; } }
        public ToleranceColor Trolerance { get { return this.trolerance; } set { this.trolerance = value; } }
        #endregion

        #region Constructor
        public Resistor()
        {

        }

        public Resistor(List<BandColors> band)
        {
            this.band = band;
        }

        public Resistor(List<BandColors> band, MultiplierColor multiplier) : this(band)
        {
            this.multiplier = multiplier;
        }

        public Resistor(List<BandColors> band, MultiplierColor multiplier, ToleranceColor Trolerance) : this(band, multiplier)
        {
            this.trolerance = Trolerance;
        }
        #endregion

        #region Methods
        
        public void SetBand(int band, BandColors color)
        {
            this.band[band] = color;
        }

        public int CalculateOhm()
        {
            string bandTogether = "";
            int ohm = 0;
            foreach (var item in this.band)
            {
                bandTogether += (int)item;
            }
            Int32.TryParse(bandTogether, out ohm);
            ohm *= (int)this.multiplier;
            return ohm;
        }

        public void FindResistor()
        {

        }

        #endregion

        #region Enum
        public enum BandColors
        {
            Black = 0,
            Brown = 1,
            Red = 2,
            Orange = 3,
            Yellow = 4,
            Green = 5,
            Blue = 6,
            Violet = 7,
            Grey = 8,
            White = 9
        }

        public enum MultiplierColor
        {
            Black = 1,
            Brown = 10,
            Red = 100,
            Orange = 1000,
            Yellow = 10000,
            Green = 100000,
            Blue = 1000000,
            Violet = 10000000
        }

        public enum ToleranceColor
        {
            Gold = 5,
            Silver = 10
        }
        #endregion
    }
}
