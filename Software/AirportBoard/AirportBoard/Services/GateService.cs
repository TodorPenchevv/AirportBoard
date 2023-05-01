using AirportBoard.Exceptions;
using AirportBoard.Models;

namespace AirportBoard.Services
{
    internal class GateService : ServiceInterface
    {
        private string id;
        private string zone;
        private string number;

        public GateService()
        {
            getFields();
        }

        public void getFields()
        {
        }

        public void save()
        {
            try
            {
                Gate gate = new Gate();
                gate.setZone(zone);
                gate.setNumber(number);
                gate.save();
            }
            catch (Exception e)
            {
                throw new InsertException();
            }
        }

        public void update()
        {
            try
            {
                Gate gate = new Gate();
                gate.setId(id);
                gate.setZone(zone);
                gate.setNumber(number);
                gate.update();
            }
            catch (Exception e)
            {
                throw new UpdateException();
            }
        }

        public void delete()
        {
            try
            {
                Gate gate = new Gate();
                gate.setId(id);
                gate.delete();
            }
            catch (Exception e)
            {
                throw new DeleteException();
            }
        }
    }
}
