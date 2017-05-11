using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWireParser
{
    public class WireBO
    {
        //SenderSuppliedInformation1500
        [FedWireTagNumber(1500, 0)]
        public string FormatVersion { get; set; }
        [FedWireTagNumber(1500,1)]
        public string UserRequestCorrelation { get; set; }
        [FedWireTagNumber(1500,2)]
        public string TestProductionCode { get; set; }
        [FedWireTagNumber(1500,3)]
        public string MessageDuplicationCode { get; set; }

        //TypeSubtype1510
        [FedWireTagNumber(1510,0)]
        public string TypeCode { get; set; }
        [FedWireTagNumber(1510, 1)]
        public string SubTypeCode { get; set; }

        //InputMessageAccountabilityDataIMAD1520
        [FedWireTagNumber(1520,0)]
        public string InputCycleDate { get; set; }
        [FedWireTagNumber(1520, 1)]
        public string InputSource { get; set; }
        [FedWireTagNumber(1520, 2)]
        public string InputSequenceNumber { get; set; }

        //Amount2000
        [FedWireTagNumber(2000,0)]
        public string Amount2000 { get; set; }


        //SenderDI3100
        [FedWireTagNumber(3100,0)]
        public string SenderABANumber { get; set; }
        [FedWireTagNumber(3100, 1)]
        public string SenderShortName { get; set; }

        //ReceiverDI3400
        [FedWireTagNumber(3400,0)]
        public string ReceiverABANumber { get; set; }
        [FedWireTagNumber(3400, 1)]
        public string ReceiverShortName { get; set; }

        //BusinessFunctionCode3600
        [FedWireTagNumber(3600,0)]
        public string BusunctionCode { get; set; }
        [FedWireTagNumber(3600, 1)]
        public string TransactionTypeCode { get; set; }


        //SenderReference3320
        [FedWireTagNumber(3320,0)]
        public string SenderReference3320 { get; set; }

        //PreviousMessageIdentifier3500
        [FedWireTagNumber(3500,0)]
        public string PreviousMessageIdentifier3500 { get; set; }

        //LocalInstrument3610
        [FedWireTagNumber(3610,0)]
        public string LocalInstrumentCode { get; set; }
        [FedWireTagNumber(3610, 1)]
        public string ProprietaryCode { get; set; }

        //PaymentNotification3620
        [FedWireTagNumber(3620,0)]
        public string PaymentNotificationIndicator { get; set; }
        [FedWireTagNumber(3620, 1)]
        public string ContactNotificationElectronicAddress { get; set; }
        [FedWireTagNumber(3620, 2)]
        public string ContactName { get; set; }
        [FedWireTagNumber(3620, 3)]
        public string ContactPhoneNumber { get; set; }
        [FedWireTagNumber(3620,4)]
        public string ContactMobileNumber { get; set; }
        [FedWireTagNumber(3620, 5)]
        public string ContactFaxNumber { get; set; }
        [FedWireTagNumber(3620, 6)]
        public string EndToEndIdentification { get; set; }

        ////Charges3700
        //[FedWireTagNumber(3700)]
        //public Charges Charges3700 = new Charges();

        ////InstructedAmount3710
        //[FedWireTagNumber(3710)]
        //public InstructedAmount InstructedAmount3710 = new InstructedAmount();

        ////ExchangeRate3720
        //[FedWireTagNumber(3720)]
        //public string ExchangeRate3720 = string.Empty;

        ////IntermediaryFI4000
        //[FedWireTagNumber(4000)]
        //public IDCodeIdentifierNameAddress IntermediaryFI4000 = new IDCodeIdentifierNameAddress();

        ////BeneficiaryFI4100
        //[FedWireTagNumber(4100)]
        //public IDCodeIdentifierNameAddress BeneficiaryFI4100 = new IDCodeIdentifierNameAddress();

        ////Beneficiary4200
        //[FedWireTagNumber(4200)]
        //public IDCodeIdentifierNameAddress Beneficiary4200 = new IDCodeIdentifierNameAddress();

        ////ReferenceForBeneficiary4320
        //[FedWireTagNumber(4320)]
        //public string ReferenceForBeneficiary4320 = string.Empty;

        ////AccountDebitedInDrawdown4400
        //[FedWireTagNumber(4400)]
        //public IDCodeIdentifierNameAddress AccountDebitedInDrawdown4400 = new IDCodeIdentifierNameAddress();

        ////Originator5000
        //[FedWireTagNumber(5000)]
        //public IDCodeIdentifierNameAddress Originator5000 = new IDCodeIdentifierNameAddress();

        ////OriginatorOptionF5010
        //[FedWireTagNumber(5010)]
        //public OriginatorOptionF OriginatorOptionF5010 = new OriginatorOptionF();

        ////OriginatorFI5100
        //[FedWireTagNumber(5100)]
        //public IDCodeIdentifierNameAddress OriginatorFI5100 = new IDCodeIdentifierNameAddress();

        ////InstructingFI5200
        //[FedWireTagNumber(5200)]
        //public IDCodeIdentifierNameAddress InstructingFI5200 = new IDCodeIdentifierNameAddress();

        ////AccountCreditedInDrawdown5400
        //[FedWireTagNumber(5400)]
        //public string AccountCreditedInDrawdown5400 = string.Empty;

        ////OriginatorToBeneficiaryInformation6000
        //[FedWireTagNumber(6000)]
        //public OriginatorToBeneficiaryInformation OriginatorToBeneficiaryInformation6000 = new OriginatorToBeneficiaryInformation();

    }
}
