using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONEYBEEAPP
{
    public class Bee
    {
        public float Health { get; protected set; }

        public virtual string BeeType { get; set; }
        public virtual bool Dead { get; }
        public Bee()
        {
            Health = 100;
        }
        public virtual void Damage(int num)
        {
            Health = Health - num;
        }


    }

    public class Worker : Bee
    {
        public override bool Dead
        {
            get
            {
                if (Health < 70)
                    return true;
                return false;
            }
        }

        public override string BeeType
        {
            get
            {
                return "Worker";

            }
        }
        public override void Damage(int num)
        {
            if (Health > 70)
                Health = Health - num;
        }
    }
    public class Queen : Bee
    {
        public override bool Dead
        {
            get
            {
                if (Health < 20)
                    return true;
                return false;
            }
        }
        public override string BeeType
        {
            get
            {
                return "Queen";

            }
        }
        public override void Damage(int num)
        {
            if (Health > 20)
                Health = Health - num;
        }
    }
    public class Drone : Bee
    {
        public override bool Dead
        {
            get
            {
                if (Health < 50)
                    return true;
                return false;
            }
        }
        public override string BeeType
        {
            get
            {
                return "Drone";

            }
        }
        public override void Damage(int num)
        {
            if (Health > 50)
                Health = Health - num;
        }
    }
}
