using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class ComputerFacade
    {
        
        private readonly Memory _memory;
        private readonly HardDisc _hardDisc;
        private readonly Processor _processor;

        public ComputerFacade()
        {
            _memory = new Memory();
            _hardDisc = new HardDisc();
            _processor = new Processor();
        }
        public void Start()
        {
            _processor.Freeze();
            _memory.Load(_hardDisc.Read());
            _processor.Jump(1200);
            _processor.Execute();
        }
    }
}
