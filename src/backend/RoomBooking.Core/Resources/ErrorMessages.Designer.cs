﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomBooking.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoomBooking.Core.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível realizar reservas aos finais de semanas..
        /// </summary>
        public static string BookDateIsWeekend {
            get {
                return ResourceManager.GetString("BookDateIsWeekend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserva para as {0} não efetuada. A sala fecha as {1}..
        /// </summary>
        public static string BookEndTimeMustBeLessThanRoomEndTime {
            get {
                return ResourceManager.GetString("BookEndTimeMustBeLessThanRoomEndTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sala inválida..
        /// </summary>
        public static string BookHasANullRoom {
            get {
                return ResourceManager.GetString("BookHasANullRoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário inválido..
        /// </summary>
        public static string BookHasANullUser {
            get {
                return ResourceManager.GetString("BookHasANullUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserva para as {0} não efetuada. A sala só abre as {1}..
        /// </summary>
        public static string BookStartTimeMustBeGreaterThanRoomStartTime {
            get {
                return ResourceManager.GetString("BookStartTimeMustBeGreaterThanRoomStartTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível realizar uma reserva no passado..
        /// </summary>
        public static string BookStartTimeMustBeInFuture {
            get {
                return ResourceManager.GetString("BookStartTimeMustBeInFuture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reserva não pode ultrapassar {0} horas..
        /// </summary>
        public static string BookTimeTotalShouldBeLessThan {
            get {
                return ResourceManager.GetString("BookTimeTotalShouldBeLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to As senhas digitadas não coincidem..
        /// </summary>
        public static string PasswordNotMatch {
            get {
                return ResourceManager.GetString("PasswordNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este perfil não é válido..
        /// </summary>
        public static string UserHasANullRole {
            get {
                return ResourceManager.GetString("UserHasANullRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha ao determinar a lista de perfis do usuário..
        /// </summary>
        public static string UserHasANullRoleList {
            get {
                return ResourceManager.GetString("UserHasANullRoleList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O nome é requerido..
        /// </summary>
        public static string UserNameIsRequired {
            get {
                return ResourceManager.GetString("UserNameIsRequired", resourceCulture);
            }
        }
    }
}
