using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class CommandCollectionEditor : CollectionEditor
    {
        public CommandCollectionEditor(Type type)
            : base(type)
        { }
        protected override bool CanSelectMultipleInstances()
        {
            return true;
        }
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[] { typeof(Item), typeof(MusicItem), typeof(ImageItem), typeof(LabelItem) 
                , typeof(MusicListItem) , typeof(MvItem)
            };
        }

        protected override object CreateInstance(Type itemType)
        {
            if (itemType == typeof(Item))
            {
                return (DMSkin.Controls.DMControlItem)(new Item());
            }
            if (itemType == typeof(MusicItem))
            {
                return (DMSkin.Controls.DMControlItem)(new MusicItem());
            }
            if (itemType == typeof(ImageItem))
            {
                return (DMSkin.Controls.DMControlItem)(new ImageItem());
            }
            if (itemType == typeof(LabelItem))
            {
                return (DMSkin.Controls.DMControlItem)(new LabelItem());
            }
            if (itemType == typeof(MusicListItem))
            {
                return (DMSkin.Controls.DMControlItem)(new MusicListItem());
            }
            if (itemType == typeof(MvItem))
            {
                return (DMSkin.Controls.DMControlItem)(new MvItem());
            }
            return null;
        }
    }
}
