﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sneg.АСУ_Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Машина.
    /// </summary>
    // *** Start programmer edit section *** (Машина CustomAttributes)

    // *** End programmer edit section *** (Машина CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("МашинаE", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность (в тоннах)\'",
            "Поступления.Количество as \'Количество\'"})]
    [View("МашинаL", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность\'",
            "Поступления.Количество as \'Количество\'"})]
    public class Машина : ICSSoft.STORMNET.DataObject
    {
        
        private string fМарка;
        
        private decimal fГрузоподъемность;
        
        private Sneg.АСУ_Склад.Поступления fПоступления;
        
        // *** Start programmer edit section *** (Машина CustomMembers)

        // *** End programmer edit section *** (Машина CustomMembers)

        
        /// <summary>
        /// Марка.
        /// </summary>
        // *** Start programmer edit section *** (Машина.Марка CustomAttributes)

        // *** End programmer edit section *** (Машина.Марка CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Марка
        {
            get
            {
                // *** Start programmer edit section *** (Машина.Марка Get start)

                // *** End programmer edit section *** (Машина.Марка Get start)
                string result = this.fМарка;
                // *** Start programmer edit section *** (Машина.Марка Get end)

                // *** End programmer edit section *** (Машина.Марка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.Марка Set start)

                // *** End programmer edit section *** (Машина.Марка Set start)
                this.fМарка = value;
                // *** Start programmer edit section *** (Машина.Марка Set end)

                // *** End programmer edit section *** (Машина.Марка Set end)
            }
        }
        
        /// <summary>
        /// Грузоподъемность.
        /// </summary>
        // *** Start programmer edit section *** (Машина.Грузоподъемность CustomAttributes)

        // *** End programmer edit section *** (Машина.Грузоподъемность CustomAttributes)
        public virtual decimal Грузоподъемность
        {
            get
            {
                // *** Start programmer edit section *** (Машина.Грузоподъемность Get start)

                // *** End programmer edit section *** (Машина.Грузоподъемность Get start)
                decimal result = this.fГрузоподъемность;
                // *** Start programmer edit section *** (Машина.Грузоподъемность Get end)

                // *** End programmer edit section *** (Машина.Грузоподъемность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.Грузоподъемность Set start)

                // *** End programmer edit section *** (Машина.Грузоподъемность Set start)
                this.fГрузоподъемность = value;
                // *** Start programmer edit section *** (Машина.Грузоподъемность Set end)

                // *** End programmer edit section *** (Машина.Грузоподъемность Set end)
            }
        }
        
        /// <summary>
        /// Машина.
        /// </summary>
        // *** Start programmer edit section *** (Машина.Поступления CustomAttributes)

        // *** End programmer edit section *** (Машина.Поступления CustomAttributes)
        [PropertyStorage(new string[] {
                "Поступления"})]
        [NotNull()]
        public virtual Sneg.АСУ_Склад.Поступления Поступления
        {
            get
            {
                // *** Start programmer edit section *** (Машина.Поступления Get start)

                // *** End programmer edit section *** (Машина.Поступления Get start)
                Sneg.АСУ_Склад.Поступления result = this.fПоступления;
                // *** Start programmer edit section *** (Машина.Поступления Get end)

                // *** End programmer edit section *** (Машина.Поступления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Машина.Поступления Set start)

                // *** End programmer edit section *** (Машина.Поступления Set start)
                this.fПоступления = value;
                // *** Start programmer edit section *** (Машина.Поступления Set end)

                // *** End programmer edit section *** (Машина.Поступления Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "МашинаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МашинаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МашинаE", typeof(Sneg.АСУ_Склад.Машина));
                }
            }
            
            /// <summary>
            /// "МашинаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МашинаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МашинаL", typeof(Sneg.АСУ_Склад.Машина));
                }
            }
        }
    }
}
