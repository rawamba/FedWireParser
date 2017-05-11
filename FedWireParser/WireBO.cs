using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWireParser
{
    public class WireBO
    {

        [FedWireTagNumber(1500)]
        public SenderSuppliedInformation SenderSuppliedInformation1500 = new SenderSuppliedInformation();

        [FedWireTagNumber(1510)]
        public TypeSubtype TypeSubtype1510 = new TypeSubtype();

        [FedWireTagNumber(1520)]
        public InputMessageAccountabilityDataIMAD InputMessageAccountabilityDataIMAD1520 = new InputMessageAccountabilityDataIMAD();

        [FedWireTagNumber(2000)]
        public string Amount2000= string.Empty;

        [FedWireTagNumber(3100)]
        public SenderDI SenderDI3100 = new SenderDI();

        [FedWireTagNumber(3400)]
        public ReceiverDI ReceiverDI3400= new ReceiverDI();

        [FedWireTagNumber(3600)]
        public BusinessFunctionCode BusinessFunctionCode3600 = new BusinessFunctionCode();

        [FedWireTagNumber(3320)]
        public string SenderReference3320 = string.Empty;

        [FedWireTagNumber(3500)]
        public string PreviousMessageIdentifier3500 = string.Empty;

        [FedWireTagNumber(3610)]
        public LocalInstrument LocalInstrument3610 = new LocalInstrument();

        [FedWireTagNumber(3620)]
        public PaymentNotification PaymentNotification3620 = new PaymentNotification();

        [FedWireTagNumber(3700)]
        public Charges Charges3700 = new Charges();

        [FedWireTagNumber(3710)]
        public InstructedAmount InstructedAmount3710 = new InstructedAmount();

        [FedWireTagNumber(3720)]
        public string ExchangeRate3720 = string.Empty;

        [FedWireTagNumber(4000)]
        public IDCodeIdentifierNameAddress IntermediaryFI4000 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(4100)]
        public IDCodeIdentifierNameAddress BeneficiaryFI4100 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(4200)]
        public IDCodeIdentifierNameAddress Beneficiary4200 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(4320)]
        public string ReferenceForBeneficiary4320 = string.Empty;

        [FedWireTagNumber(4400)]
        public IDCodeIdentifierNameAddress AccountDebitedInDrawdown4400 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(5000)]
        public IDCodeIdentifierNameAddress Originator5000 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(5010)]
        public OriginatorOptionF OriginatorOptionF5010 = new OriginatorOptionF();

        [FedWireTagNumber(5100)]
        public IDCodeIdentifierNameAddress OriginatorFI5100 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(5200)]
        public IDCodeIdentifierNameAddress InstructingFI5200 = new IDCodeIdentifierNameAddress();

        [FedWireTagNumber(5400)]
        public string AccountCreditedInDrawdown5400 = string.Empty;

        [FedWireTagNumber(6000)]
        public OriginatorToBeneficiaryInformation OriginatorToBeneficiaryInformation6000 = new OriginatorToBeneficiaryInformation();

        //public Tuple<string, SenderSuppliedInformation> SenderSuppliedInformation1500;
        //public Tuple<string, TypeSubtype> TypeSubtype1510;
        //public Tuple<string, InputMessageAccountabilityDataIMAD> InputMessageAccountabilityDataIMAD1520;
        //public Tuple<string, string> Amount2000;
        //public Tuple<string, SenderDI> SenderDI3100;
        //public Tuple<string, ReceiverDI> ReceiverDI3400;
        //public Tuple<string, BusinessFunctionCode> BusinessFunctionCode3600;
        //public Tuple<string, string> SenderReference3320;
        //public Tuple<string, string> PreviousMessageIdentifier3500;
        //public Tuple<string, LocalInstrument> LocalInstrument3610;
        //public Tuple<string, PaymentNotification> PaymentNotification3620;
        //public Tuple<string, Charges> Charges3700;
        //public Tuple<string, InstructedAmount> InstructedAmount3710;
        //public Tuple<string, string> ExchangeRate3720;
        //public Tuple<string, IDCodeIdentifierNameAddress> IntermediaryFI4000;
        //public Tuple<string, IDCodeIdentifierNameAddress> BeneficiaryFI4100;
        //public Tuple<string, IDCodeIdentifierNameAddress> Beneficiary4200;
        //public Tuple<string, string> ReferenceForBeneficiary4320;
        //public Tuple<string, IDCodeIdentifierNameAddress> AccountDebitedInDrawdown4400;
        //public Tuple<string, IDCodeIdentifierNameAddress> Originator5000;
        //public Tuple<string, OriginatorOptionF> OriginatorOptionF5010;
        //public Tuple<string, IDCodeIdentifierNameAddress> OriginatorFI5100;
        //public Tuple<string, IDCodeIdentifierNameAddress>  InstructingFI5200;
        //public Tuple<string, string> AccountCreditedInDrawdown5400;
        //public Tuple<string, OriginatorToBeneficiaryInformation> OriginatorToBeneficiaryInformation6000;

    }
}
