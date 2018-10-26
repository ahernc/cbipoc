using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XsdClasses.cbipoc;

namespace cbipoc
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new CounterPartyList
            {
                CounterParty = {
                }
            };


            // This will be the imaginary line read from the CSV file... 
            var someCounterParty = new CounterPartyListCounterParty();
            someCounterParty.AccountingStandard = AccountingStandardEnum.NP;
            someCounterParty.Address = new CounterPartyListCounterPartyAddress
            {
                City = "Cork",
                Country = CountryEnum.IE,
                CountyAdminDivision = CountyAdminDivisionEnum.PL114,
                Date = new DateTime(2018, 12, 12),
                IrishCounty = IrishCountyEnum.Item14,
                PostalCode = "C123456",
                Street = "Main Street"
            };

            someCounterParty.AnnualTurnover = new CounterPartyListCounterPartyAnnualTurnover
            {
                Date = DateTime.Today,
                Value = "52,512"
            };

            someCounterParty.BalanceSheetTotal = new CounterPartyListCounterPartyBalanceSheetTotal
            {
                Date = DateTime.Today,
                Value = "1,234,567"
            };

            someCounterParty.EconomicActivity = EconomicActivityEnum.Item01_16;

            someCounterParty.EnterpriseSize = new CounterPartyListCounterPartyEnterpriseSize
            {
                Date = DateTime.Now,
                Value = EnterpriseSizeEnum.NR
            };

            someCounterParty.Identifiers = new IdentifierType
            {
                CounterPartyId = "ABC123",
                CROId = "999541",
                HeadOfficeUndertakingId = "A Head Office",
                IdFreeText = "Random Id Here",
                ImmediateParentUndertakingId = "An Undertaking Id",
                LegalEntityId = "LegalEntity Number",
                // NonIrishId
                // OtherIrishId
                ReportingAgentId = "the Reporter",
                RIADId = "A Value Here",
                UltimateParentUndertakingId = "GDH7772",
                VATId = "123489IE"
            };

            someCounterParty.InstitutionalSector = InstitutionalSectorEnum.S125_A;

            someCounterParty.LegalForm = LegalFormEnum.AT401;

            someCounterParty.Name = "Bank of Ireland Cork";

            someCounterParty.NumberOfEmployees = new CounterPartyListCounterPartyNumberOfEmployees
            {
                Date = DateTime.Today,
                Value = "123"
            };

            someCounterParty.ReferenceDate = ReferenceDateEnum.Item20240331;

            someCounterParty.Roles = new RolesType
            {
                Role01ReportingAgent = false,
                Role02ObservedAgent = true,
                Role03Creditor = false,
                Role04DebtorAllBefore1Sep2018 = true,
                Role05DebtorOneAtOrAfter1Sep2018 = false,
                Role06ProtectionProvider = true,
                Role07HeadOfficeUndertaking = false,
                Role08ImmediateParentUndertaking = true,
                Role09UltimateParentUndertaking = false,
                Role10Originator = true,
                Role11Servicer = false
            };

            someCounterParty.StatusOfLegalProceedings = new CounterPartyListCounterPartyStatusOfLegalProceedings
            {
                Date = DateTime.Today,
                Value = LegalStatusEnum.Item4
            };



            // add to the list: this should be mimicking a line read from the CSV file:
            list.CounterParty.Add(someCounterParty);

            XmlSerializer ser = new XmlSerializer(typeof(CounterPartyList));

            
            using (var sww = new StringWriter())
            {

                using (XmlWriter xw = XmlWriter.Create($"C:\\_github\\cbipoc\\testoutput\\test_{DateTime.Now.Ticks}.xml"))
                {
                    ser.Serialize(xw, list);
                    
                }
            }
        }
    }
}
