using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Observer.BidiractionalBinding
{
    public sealed class BdiireactionalBinding : IDisposable
    {
        private bool disposed;


        public BdiireactionalBinding(
            INotifyPropertyChanged first,
            Expression<Func<object>> firstProperty,
            INotifyPropertyChanged second,
            Expression<Func<object>> secondProperty)
        {
            if (firstProperty.Body is MemberExpression firstExr
            && secondProperty.Body is MemberExpression secondExpr)
            {
                if (firstExr.Member is PropertyInfo firstProp
                && secondExpr.Member is PropertyInfo secondProp)
                {
                    first.PropertyChanged += (sender, args) =>
                    {
                        if (!disposed)
                            secondProp.SetValue(second, firstProp.GetValue(first));
                    };
                    second.PropertyChanged += (sender, args) =>
                    {
                        if (!disposed)
                            firstProp.SetValue(first, secondProp.GetValue(second));
                    };
                }
            }
        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}
