using AutoIt;
using Core.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerCore.ClickerActions
{
    internal class BaseAction : IClickerAction
    {
        protected readonly AutoItX3 _auto;
        public BaseAction()
        {

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
