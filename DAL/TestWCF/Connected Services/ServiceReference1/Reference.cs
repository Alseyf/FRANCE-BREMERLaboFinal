﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilmDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class FilmDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdFilmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterpathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RuntimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float VoteAverageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdFilm {
            get {
                return this.IdFilmField;
            }
            set {
                if ((this.IdFilmField.Equals(value) != true)) {
                    this.IdFilmField = value;
                    this.RaisePropertyChanged("IdFilm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posterpath {
            get {
                return this.PosterpathField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterpathField, value) != true)) {
                    this.PosterpathField = value;
                    this.RaisePropertyChanged("Posterpath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Runtime {
            get {
                return this.RuntimeField;
            }
            set {
                if ((this.RuntimeField.Equals(value) != true)) {
                    this.RuntimeField = value;
                    this.RaisePropertyChanged("Runtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float VoteAverage {
            get {
                return this.VoteAverageField;
            }
            set {
                if ((this.VoteAverageField.Equals(value) != true)) {
                    this.VoteAverageField = value;
                    this.RaisePropertyChanged("VoteAverage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CharacterDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class CharacterDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CharacterNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CharacterName {
            get {
                return this.CharacterNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CharacterNameField, value) != true)) {
                    this.CharacterNameField = value;
                    this.RaisePropertyChanged("CharacterName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LightFilmDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class LightFilmDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float VoteAverageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float VoteAverage {
            get {
                return this.VoteAverageField;
            }
            set {
                if ((this.VoteAverageField.Equals(value) != true)) {
                    this.VoteAverageField = value;
                    this.RaisePropertyChanged("VoteAverage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActorDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(TestWCF.ServiceReference1.FullActorDTO))]
    public partial class ActorDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FullActorDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class FullActorDTO : TestWCF.ServiceReference1.ActorDTO {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommentDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class CommentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string avatarField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string avatar {
            get {
                return this.avatarField;
            }
            set {
                if ((object.ReferenceEquals(this.avatarField, value) != true)) {
                    this.avatarField = value;
                    this.RaisePropertyChanged("avatar");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListFilmsByIdActor", ReplyAction="http://tempuri.org/IService1/GetListFilmsByIdActorResponse")]
        TestWCF.ServiceReference1.FilmDTO[] GetListFilmsByIdActor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListFilmsByIdActor", ReplyAction="http://tempuri.org/IService1/GetListFilmsByIdActorResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference1.FilmDTO[]> GetListFilmsByIdActorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListCharacterByIdActorAndIdFilm", ReplyAction="http://tempuri.org/IService1/GetListCharacterByIdActorAndIdFilmResponse")]
        TestWCF.ServiceReference1.CharacterDTO[] GetListCharacterByIdActorAndIdFilm(int idAct, int idFilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListCharacterByIdActorAndIdFilm", ReplyAction="http://tempuri.org/IService1/GetListCharacterByIdActorAndIdFilmResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference1.CharacterDTO[]> GetListCharacterByIdActorAndIdFilmAsync(int idAct, int idFilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindListFilmByPartialActorName", ReplyAction="http://tempuri.org/IService1/FindListFilmByPartialActorNameResponse")]
        TestWCF.ServiceReference1.FilmDTO[] FindListFilmByPartialActorName(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindListFilmByPartialActorName", ReplyAction="http://tempuri.org/IService1/FindListFilmByPartialActorNameResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference1.FilmDTO[]> FindListFilmByPartialActorNameAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFavoriteFilms", ReplyAction="http://tempuri.org/IService1/GetFavoriteFilmsResponse")]
        TestWCF.ServiceReference1.LightFilmDTO[] GetFavoriteFilms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFavoriteFilms", ReplyAction="http://tempuri.org/IService1/GetFavoriteFilmsResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference1.LightFilmDTO[]> GetFavoriteFilmsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFullActorDetailsByIdActor", ReplyAction="http://tempuri.org/IService1/GetFullActorDetailsByIdActorResponse")]
        TestWCF.ServiceReference1.FullActorDTO GetFullActorDetailsByIdActor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFullActorDetailsByIdActor", ReplyAction="http://tempuri.org/IService1/GetFullActorDetailsByIdActorResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference1.FullActorDTO> GetFullActorDetailsByIdActorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertCommentOnActorId", ReplyAction="http://tempuri.org/IService1/InsertCommentOnActorIdResponse")]
        bool InsertCommentOnActorId(int id, TestWCF.ServiceReference1.CommentDTO commDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertCommentOnActorId", ReplyAction="http://tempuri.org/IService1/InsertCommentOnActorIdResponse")]
        System.Threading.Tasks.Task<bool> InsertCommentOnActorIdAsync(int id, TestWCF.ServiceReference1.CommentDTO commDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestWCF.ServiceReference1.IService1>, TestWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestWCF.ServiceReference1.FilmDTO[] GetListFilmsByIdActor(int id) {
            return base.Channel.GetListFilmsByIdActor(id);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference1.FilmDTO[]> GetListFilmsByIdActorAsync(int id) {
            return base.Channel.GetListFilmsByIdActorAsync(id);
        }
        
        public TestWCF.ServiceReference1.CharacterDTO[] GetListCharacterByIdActorAndIdFilm(int idAct, int idFilm) {
            return base.Channel.GetListCharacterByIdActorAndIdFilm(idAct, idFilm);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference1.CharacterDTO[]> GetListCharacterByIdActorAndIdFilmAsync(int idAct, int idFilm) {
            return base.Channel.GetListCharacterByIdActorAndIdFilmAsync(idAct, idFilm);
        }
        
        public TestWCF.ServiceReference1.FilmDTO[] FindListFilmByPartialActorName(string s) {
            return base.Channel.FindListFilmByPartialActorName(s);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference1.FilmDTO[]> FindListFilmByPartialActorNameAsync(string s) {
            return base.Channel.FindListFilmByPartialActorNameAsync(s);
        }
        
        public TestWCF.ServiceReference1.LightFilmDTO[] GetFavoriteFilms() {
            return base.Channel.GetFavoriteFilms();
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference1.LightFilmDTO[]> GetFavoriteFilmsAsync() {
            return base.Channel.GetFavoriteFilmsAsync();
        }
        
        public TestWCF.ServiceReference1.FullActorDTO GetFullActorDetailsByIdActor() {
            return base.Channel.GetFullActorDetailsByIdActor();
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference1.FullActorDTO> GetFullActorDetailsByIdActorAsync() {
            return base.Channel.GetFullActorDetailsByIdActorAsync();
        }
        
        public bool InsertCommentOnActorId(int id, TestWCF.ServiceReference1.CommentDTO commDTO) {
            return base.Channel.InsertCommentOnActorId(id, commDTO);
        }
        
        public System.Threading.Tasks.Task<bool> InsertCommentOnActorIdAsync(int id, TestWCF.ServiceReference1.CommentDTO commDTO) {
            return base.Channel.InsertCommentOnActorIdAsync(id, commDTO);
        }
    }
}