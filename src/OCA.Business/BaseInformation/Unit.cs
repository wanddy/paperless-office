using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class Unit
    {
        OCA.DataAccess.BaseInformation.Unit unitclass = new OCA.DataAccess.BaseInformation.Unit();
        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();

        public Boolean IsExistUnit(string UnitName)
        {
            try
            {
                dsunit.Clear();
                dsunit = unitclass.IsExistUnit(UnitName);
                if (dsunit.Tbl_Unit.Rows.Count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public OCA.Common.DataSets.BaseInformation.Unit GetUnits()
        {
            try
            {
                dsunit.Clear();
                dsunit = unitclass.GetUnits();
                return dsunit;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Unit GetAllUnits()
        {
            try
            {
                dsunit.Clear();
                dsunit = unitclass.GetAllUnits();
                return dsunit;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertUnit(string UnitName, string UpperUnit)
        {
            try
            {
                unitclass.InsertUnit(UnitName, UpperUnit);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveUnit(string UnitName)
        {
            try
            {
                unitclass.RemoveUnit(UnitName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveSubUnits(string UnitName)
        {
            try
            {
                dsunit.Clear();
                dsunit = unitclass.GetUnits();

                RemoveSubUnit(UnitName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void RemoveSubUnit(string UnitName)
        {
            for (int i = 1; i <= dsunit.Tbl_Unit.Rows.Count;i++)
            {
                if (dsunit.Tbl_Unit[i - 1].UpperUnit.Trim() == UnitName)
                    RemoveSubUnit(dsunit.Tbl_Unit[i - 1].UnitName.Trim());
            }
            unitclass.RemoveUnit(UnitName);
        }

        public void EditUnit(string UnitName, string newUnitName)
        {
            try
            {
                unitclass.EditUnit(UnitName,newUnitName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
