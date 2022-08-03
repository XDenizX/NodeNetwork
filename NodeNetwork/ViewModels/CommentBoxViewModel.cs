using NodeNetwork.Views;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;

namespace NodeNetwork.ViewModels
{
    public class CommentBoxViewModel : ReactiveObject
    {
        static CommentBoxViewModel()
        {
            NNViewRegistrar.AddRegistration(() => new CommentBoxView(), typeof(IViewFor<CommentBoxViewModel>));
        }

        #region Parent
        /// <summary>
        /// The network that contains this node
        /// </summary>
        public NetworkViewModel Parent
        {
            get => _parent;
            internal set => this.RaiseAndSetIfChanged(ref _parent, value);
        }
        private NetworkViewModel _parent;
        #endregion

        #region Description
        public string Description
        {
            get => _description;
            internal set => this.RaiseAndSetIfChanged(ref _description, value);
        }
        private string _description;
        #endregion

        public CommentBoxViewModel()
        {

        }
    }
}
