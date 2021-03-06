﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDrawingKit.Interface
{
    public class Observerable //Object yang di-observe
    {
        private LinkedList<IObserver> listObserver = new LinkedList<IObserver>();

        public void attach(IObserver observer)
        {
            listObserver.AddLast(observer);
        }

        public void detach(IObserver observer)
        {
            listObserver.Remove(observer);
        }

        public void notify()
        {
            foreach(IObserver observer in this.listObserver)
            {
                observer.Update(this);
            }
        }
    }
}
