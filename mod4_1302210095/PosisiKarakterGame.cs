using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace mod4_1302210095
{
    internal class PosisiKarakterGame
    {
        public KarakterState currentState;
        public enum KarakterState {Tengkurap, Jongkok, Berdiri, Terbang};
        public enum Trigger { TombolW,TombolS,TombolX};
        
        class Transition
        {
            public KarakterState prevState;
            public KarakterState nextState;
            public Trigger trigger;
            public Transition(KarakterState prevState, KarakterState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
        Transition[] transitions =
        {
            new Transition(KarakterState.Tengkurap, KarakterState.Jongkok, Trigger.TombolW),
            new Transition(KarakterState.Jongkok, KarakterState.Berdiri, Trigger.TombolW),
            new Transition(KarakterState.Berdiri, KarakterState.Terbang, Trigger.TombolW),
            new Transition(KarakterState.Terbang, KarakterState.Berdiri, Trigger.TombolS),
            new Transition(KarakterState.Berdiri, KarakterState.Jongkok, Trigger.TombolS),
            new Transition(KarakterState.Jongkok, KarakterState.Tengkurap, Trigger.TombolS),
            new Transition(KarakterState.Terbang, KarakterState.Jongkok, Trigger.TombolX)
        };

        public KarakterState getNextState(KarakterState prevState, Trigger trigger)
        {
            string[] output = { "aku jongkok", "aku berdiri", "posisi take off", "aku turun", "aku menjongkok", "aku mentengkurap", "posisi landing","tidak apa apa" };
            int i = 0;   
            KarakterState nextState = prevState;
            foreach (Transition transition in transitions)
            {
                if (transition.prevState == prevState && transition.trigger == trigger)
                {
                    nextState = transition.nextState;
                    break;
                }
                i++;
            }
            Console.WriteLine(output[i]);
            return nextState;
        }
        public void activeTrigger(Trigger trigger)
        {
            
            KarakterState nextState = getNextState(currentState, trigger);
            currentState = nextState;
            Console.WriteLine("Trigger: " + Convert.ToString(trigger) + "!");
            Console.WriteLine(Convert.ToString(currentState));
            Console.WriteLine();
        }

    }
}
