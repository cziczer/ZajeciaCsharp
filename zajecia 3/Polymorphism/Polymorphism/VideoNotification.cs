using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class VideoNotification
    {
        private readonly IList<INotificationChannel> _notificationChannels; 

        public VideoNotification()
            {
                _notificationChannels = new List<INotificationChannel>();
            }

            public void Notification()
            {

            foreach (var channel in _notificationChannels)
                channel.Send();
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }

}
