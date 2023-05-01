﻿using AirportBoard.Logging;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class DestinationService : Service
    {
        private string id;
        private string airport;
        private string cityId;

        public DestinationService() {}

        public override void setFields(Dictionary<string, string> values)
        {
            id = valueContains(values, "id");
            airport = valueContains(values, "airport");
            cityId = valueContains(values, "cityId");
        }

        public override void save()
        {
            try
            {
                Destination destination = new Destination();
                destination.setAirport(airport);
                destination.setCityId(cityId);
                destination.save();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }

        public override void update()
        {
            try
            {
                Destination destination = new Destination();
                destination.setId(id);
                destination.setAirport(airport);
                destination.setCityId(cityId);
                destination.update();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }

        public override void delete()
        {
            try
            {
                Destination destination = new Destination();
                destination.setId(id);
                destination.delete();
            }
            catch (Exception e)
            {
                Notification.show("Error", e.Message);
            }
        }
    }
}
