using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection;

namespace RepositoryPattern.Helper
{
    public static class ConvertToDTO
    {
        public static TOut Convert<TIn,TOut>(TIn fromRecord) where TOut : new()
        {
            var toRecord = new TOut();
            PropertyInfo[] fromFields = null;
            PropertyInfo[] toFields = null;

            fromFields = typeof(TOut).GetProperties();
            toFields = typeof(TIn).GetProperties();

            foreach (var fromField in fromFields)
            {
                foreach (var toField in toFields)
                {
                    if (fromField.Name == toField.Name)
                    {
                        toField.SetValue(toRecord, fromField.GetValue(fromRecord, null), null);
                        break;
                    }
                }

            }
            return toRecord;
        }

        public static IEnumerable<TOut> Convert<TIn,TOut>(List<TIn> fromRecordList) where TOut : new()
        {
            return fromRecordList.Count == 0 ? null : fromRecordList.Select(Convert<TOut, TIn>).ToList();
        }
    }
}