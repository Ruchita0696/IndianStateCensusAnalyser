using IndianStateCensusAnalyser.DataDOA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser.DTO
{
    public class CensusDTO
    {
        /// Combining two classes into single class
        public int serialNumber;
        public string stateName;
        public string stateCode;
        public int tin;
        public string state;
        public long population;
        public long area;
        public long density;
        /// <summary>
        /// constructor to use census data constructor
        /// </summary>
        /// <param name="censusDataDAO"></param>
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }
        /// <summary>
        /// constructor to use state codes constructor
        /// </summary>
        /// <param name="stateCodesDAO"></param>
        public CensusDTO(StateCodesDAO stateCodesDAO)
        {
            this.serialNumber = stateCodesDAO.serialNumber;
            this.stateName = stateCodesDAO.stateName;
            this.stateCode = stateCodesDAO.stateCode;
            this.tin = stateCodesDAO.tin;
        }
    }
}
