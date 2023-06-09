﻿using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class GateService : Service
    {
        private string id;
        private string zone;
        private string number;

        public GateService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            zone = valueContains(values, "zone");
            number = valueContains(values, "number");
        }

        public override void save()
        {
            Gate gate = new Gate();
            gate.setZone(zone);
            gate.setNumber(number);
            gate.save();
        }

        public override void update()
        {
            Gate gate = new Gate();
            gate.setId(id);
            gate.setZone(zone);
            gate.setNumber(number);
            gate.update();
        }

        public override void delete()
        {
            Gate gate = new Gate();
            gate.setId(id);
            gate.delete();
        }
    }
}
