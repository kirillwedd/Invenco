using Invenco.Entity;
using Invenco.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invenco.ClassEntity
{
    class EntityViewModel
    {
       static ObservableCollection<Invertarization> invertarizationObserve;
       static ObservableCollection<HistoryInvertarization> HistoryInvertarizationsObserve;

        public EntityViewModel()
        {
            invertarizationObserve= new ObservableCollection<Invertarization>();
            HistoryInvertarizationsObserve= new ObservableCollection<HistoryInvertarization>();
        }

        public void DeleteAndTransferItem(Table1Item item)
        {
            // Удаление из таблицы 1
            table1Items.Remove(item);

            // Передача данных в таблицу 2
            var transferItem = new Table2Item
            {
                Id = item.Id,
                // Копирование остальных свойств из item в transferItem
                // transferItem.OtherProperty = item.OtherProperty;
            };
            table2Items.Add(transferItem);
        }
    }
}
