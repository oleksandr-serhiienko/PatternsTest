using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Participant
    {
        private Mediator mediator;
        public int Value { get; set; }

        public Participant(Mediator mediator)
        {
            Value = 0;
            this.mediator = mediator;
            mediator.Participants.Add(this);
        }

        public void Say(int n)
        {
            mediator.BroadCast(this, n);
        }
    }

    public class Mediator
    {
        public List<Participant> Participants = new List<Participant>();

        public void BroadCast(Participant participant, int n)
        {
            foreach (var paticipant in Participants)
                if (!paticipant.Equals(participant))
                    paticipant.Value += n;
        }
    }
}
