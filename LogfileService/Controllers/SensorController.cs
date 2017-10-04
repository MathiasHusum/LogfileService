using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogfileService.Models;

namespace LogfileService.Controllers
{
    public class SensorController : ApiController
    {
        private List<Sensor> sensors = new List<Sensor>();

        // GET: api/Sensor
        public List<Sensor> Get()
        {
            return sensors;
        }

        // POST: api/Sensor
        public void Post(int id, string alarm, string navn, string afdeling, string bolig, DateTime tid)
        {
            Bolig Bolig = new Bolig()
            {
                _Bolig = bolig,
                Afdeling = afdeling
            };

            Sensor Sensor = new Sensor()
            {
                ID = id,
                Alarm = alarm,
                Tid = tid,
                Bolig = Bolig
            };

            sensors.Add(Sensor);
        }

        // PUT: api/Sensor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sensor/5
        public void Delete(int id)
        {
        }
    }
}
