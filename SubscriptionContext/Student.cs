using BaltaCourse.NotificationContext;
using BaltaCourse.SharedContext;
using BaltaCourse.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaCourse.SubscriptionContent
{
    public class Student:Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já possui uma assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsActive);
    }
}
