using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedWireParser
{
    class WireBO
    {
        public Tuple<string, SenderSuppliedInformation> SenderSuppliedInformation1500;
        public Tuple<string, TypeSubtype> TypeSubtype1510;
        public Tuple<string, InputMessageAccountabilityDataIMAD> InputMessageAccountabilityDataIMAD1520;
        public Tuple<string, string> Amount2000;
        public Tuple<string, SenderDI> SenderDI3100;
        public Tuple<string, ReceiverDI> ReceiverDI3400;
        public Tuple<string, BusinessFunctionCode> BusinessFunctionCode3600;
        public Tuple<string, string> SenderReference3320;
        public Tuple<string, string> PreviousMessageIdentifier3500;
        public Tuple<string, LocalInstrument> LocalInstrument3610;
        public Tuple<string, PaymentNotification> PaymentNotification3620;
        public Tuple<string, Charges> Charges3700;
        public Tuple<string, InstructedAmount> InstructedAmount3710;
        public Tuple<string, string> ExchangeRate3720;
        public Tuple<string, IDCodeIdentifierNameAddress> IntermediaryFI4000;
        public Tuple<string, IDCodeIdentifierNameAddress> BeneficiaryFI4100;
        public Tuple<string, IDCodeIdentifierNameAddress> Beneficiary4200;
        public Tuple<string, string> ReferenceForBeneficiary4320;
        public Tuple<string, IDCodeIdentifierNameAddress> AccountDebitedInDrawdown4400;
        public Tuple<string, IDCodeIdentifierNameAddress> Originator5000;
        public Tuple<string, OriginatorOptionF> OriginatorOptionF5010;
        public Tuple<string, IDCodeIdentifierNameAddress> OriginatorFI5100;
        public Tuple<string, IDCodeIdentifierNameAddress>  InstructingFI5200;
        public Tuple<string, string> AccountCreditedInDrawdown5400;
        public Tuple<string, OriginatorToBeneficiaryInformation> OriginatorToBeneficiaryInformation6000;
      
    }
}
