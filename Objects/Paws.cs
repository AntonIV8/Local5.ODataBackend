﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.local5
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Paws.
    /// </summary>
    //  *** Start programmer edit section *** (Paws CustomAttributes)

    //  *** End programmer edit section *** (Paws CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("PawsE", new string[] {
            "Direction as \'Direction\'"})]
    public class Paws : ICSSoft.STORMNET.DataObject
    {
        
        private string fDirection;
        
        private IIS.local5.Cat fCat;
        
        //  *** Start programmer edit section *** (Paws CustomMembers)

        //  *** End programmer edit section *** (Paws CustomMembers)

        
        /// <summary>
        /// Direction.
        /// </summary>
        //  *** Start programmer edit section *** (Paws.Direction CustomAttributes)

        //  *** End programmer edit section *** (Paws.Direction CustomAttributes)
        [StrLen(255)]
        public virtual string Direction
        {
            get
            {
                //  *** Start programmer edit section *** (Paws.Direction Get start)

                //  *** End programmer edit section *** (Paws.Direction Get start)
                string result = this.fDirection;
                //  *** Start programmer edit section *** (Paws.Direction Get end)

                //  *** End programmer edit section *** (Paws.Direction Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Paws.Direction Set start)

                //  *** End programmer edit section *** (Paws.Direction Set start)
                this.fDirection = value;
                //  *** Start programmer edit section *** (Paws.Direction Set end)

                //  *** End programmer edit section *** (Paws.Direction Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.local5.Cat.
        /// </summary>
        //  *** Start programmer edit section *** (Paws.Cat CustomAttributes)

        //  *** End programmer edit section *** (Paws.Cat CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Cat"})]
        public virtual IIS.local5.Cat Cat
        {
            get
            {
                //  *** Start programmer edit section *** (Paws.Cat Get start)

                //  *** End programmer edit section *** (Paws.Cat Get start)
                IIS.local5.Cat result = this.fCat;
                //  *** Start programmer edit section *** (Paws.Cat Get end)

                //  *** End programmer edit section *** (Paws.Cat Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Paws.Cat Set start)

                //  *** End programmer edit section *** (Paws.Cat Set start)
                this.fCat = value;
                //  *** Start programmer edit section *** (Paws.Cat Set end)

                //  *** End programmer edit section *** (Paws.Cat Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "PawsE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PawsE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PawsE", typeof(IIS.local5.Paws));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Paws.
    /// </summary>
    //  *** Start programmer edit section *** (DetailArrayDetailArrayOfPaws CustomAttributes)

    //  *** End programmer edit section *** (DetailArrayDetailArrayOfPaws CustomAttributes)
    public class DetailArrayOfPaws : ICSSoft.STORMNET.DetailArray
    {
        
        //  *** Start programmer edit section *** (IIS.local5.DetailArrayOfPaws members)

        //  *** End programmer edit section *** (IIS.local5.DetailArrayOfPaws members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Paws by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Paws.
        /// </summary>
        public DetailArrayOfPaws(IIS.local5.Cat fCat) : 
                base(typeof(Paws), ((ICSSoft.STORMNET.DataObject)(fCat)))
        {
        }
        
        public IIS.local5.Paws this[int index]
        {
            get
            {
                return ((IIS.local5.Paws)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.local5.Paws dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
