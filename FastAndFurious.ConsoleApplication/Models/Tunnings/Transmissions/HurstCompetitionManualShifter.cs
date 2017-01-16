using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class HurstCompetitionManualShifter : Transmission, ITransmission, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int HurstCompetitionManualShifterWeightInGrams = 6000;
        private const int HurstCompetitionManualShifterAccelerationBonus = 20;
        private const int HurstCompetitionManualShifterTopSpeedBonus = 0;
        private const decimal HurstCompetitionManualShifterPriceInUSADollars = 1999;

        public HurstCompetitionManualShifter()
            : base(
                  HurstCompetitionManualShifterPriceInUSADollars,
                  HurstCompetitionManualShifterWeightInGrams,
                  HurstCompetitionManualShifterAccelerationBonus,
                  HurstCompetitionManualShifterTopSpeedBonus,
                  TunningGradeType.MidGrade,
                  TransmissionType.StockShifter)
        {
        }
    }
}