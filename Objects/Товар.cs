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
    /// Товар.
    /// </summary>
    // *** Start programmer edit section *** (Товар CustomAttributes)

    // *** End programmer edit section *** (Товар CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТоварE", new string[] {
            "Номер as \'Номер\'",
            "Название as \'Название\'",
            "ТоварНаСкладе.Количество as \'Товаров на складе (количество)\'",
            "Поступления.Количество as \'Поступления (количество)\'"})]
    [View("ТоварL", new string[] {
            "Номер as \'Номер\'",
            "Название as \'Название\'",
            "ТоварНаСкладе.Количество as \'Количество\'",
            "Поступления.Количество as \'Количество\'"})]
    public class Товар : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private string fНазвание;
        
        private Sneg.АСУ_Склад.ТоварНаСкладе fТоварНаСкладе;
        
        private Sneg.АСУ_Склад.Поступления fПоступления;
        
        // *** Start programmer edit section *** (Товар CustomMembers)

        // *** End programmer edit section *** (Товар CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Товар.Номер CustomAttributes)

        // *** End programmer edit section *** (Товар.Номер CustomAttributes)
        [NotNull()]
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Товар.Номер Get start)

                // *** End programmer edit section *** (Товар.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Товар.Номер Get end)

                // *** End programmer edit section *** (Товар.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товар.Номер Set start)

                // *** End programmer edit section *** (Товар.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Товар.Номер Set end)

                // *** End programmer edit section *** (Товар.Номер Set end)
            }
        }
        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Товар.Название CustomAttributes)

        // *** End programmer edit section *** (Товар.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Товар.Название Get start)

                // *** End programmer edit section *** (Товар.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Товар.Название Get end)

                // *** End programmer edit section *** (Товар.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товар.Название Set start)

                // *** End programmer edit section *** (Товар.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Товар.Название Set end)

                // *** End programmer edit section *** (Товар.Название Set end)
            }
        }
        
        /// <summary>
        /// Товар.
        /// </summary>
        // *** Start programmer edit section *** (Товар.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (Товар.ТоварНаСкладе CustomAttributes)
        [PropertyStorage(new string[] {
                "ТоварНаСкладе"})]
        public virtual Sneg.АСУ_Склад.ТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (Товар.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (Товар.ТоварНаСкладе Get start)
                Sneg.АСУ_Склад.ТоварНаСкладе result = this.fТоварНаСкладе;
                // *** Start programmer edit section *** (Товар.ТоварНаСкладе Get end)

                // *** End programmer edit section *** (Товар.ТоварНаСкладе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товар.ТоварНаСкладе Set start)

                // *** End programmer edit section *** (Товар.ТоварНаСкладе Set start)
                this.fТоварНаСкладе = value;
                // *** Start programmer edit section *** (Товар.ТоварНаСкладе Set end)

                // *** End programmer edit section *** (Товар.ТоварНаСкладе Set end)
            }
        }
        
        /// <summary>
        /// Товар.
        /// </summary>
        // *** Start programmer edit section *** (Товар.Поступления CustomAttributes)

        // *** End programmer edit section *** (Товар.Поступления CustomAttributes)
        [PropertyStorage(new string[] {
                "Поступления"})]
        [NotNull()]
        public virtual Sneg.АСУ_Склад.Поступления Поступления
        {
            get
            {
                // *** Start programmer edit section *** (Товар.Поступления Get start)

                // *** End programmer edit section *** (Товар.Поступления Get start)
                Sneg.АСУ_Склад.Поступления result = this.fПоступления;
                // *** Start programmer edit section *** (Товар.Поступления Get end)

                // *** End programmer edit section *** (Товар.Поступления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товар.Поступления Set start)

                // *** End programmer edit section *** (Товар.Поступления Set start)
                this.fПоступления = value;
                // *** Start programmer edit section *** (Товар.Поступления Set end)

                // *** End programmer edit section *** (Товар.Поступления Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТоварE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварE", typeof(Sneg.АСУ_Склад.Товар));
                }
            }
            
            /// <summary>
            /// "ТоварL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварL", typeof(Sneg.АСУ_Склад.Товар));
                }
            }
        }
    }
}
