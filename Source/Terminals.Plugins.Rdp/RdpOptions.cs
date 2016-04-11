﻿using System;

namespace Terminals.Data
{
    [Serializable]
    public class RdpOptions : ProtocolOptions
    {
        public Boolean ConnectToConsole { get; set; }
        public Boolean GrabFocusOnConnect { get; set; }
        public Boolean FullScreen { get; set; }

        private RdpUserInterfaceOptions userInterface = new RdpUserInterfaceOptions();
        public RdpUserInterfaceOptions UserInterface
        {
            get { return this.userInterface; }
            set { this.userInterface = value; }
        }

        private RdpSecurityOptions security = new RdpSecurityOptions();
        public RdpSecurityOptions Security
        {
            get { return this.security; }
            set { this.security = value; }
        }

        private RdpTimeOutOptions timeOuts = new RdpTimeOutOptions();
        public RdpTimeOutOptions TimeOuts
        {
            get { return this.timeOuts; }
            set { this.timeOuts = value; }
        }

        private RdpRedirectOptions redirect = new RdpRedirectOptions();
        public RdpRedirectOptions Redirect
        {
            get { return this.redirect; }
            set { this.redirect = value; }
        }

        private TsGwOptions tsGateway = new TsGwOptions();
        public TsGwOptions TsGateway
        {
            get { return this.tsGateway; }
            set { this.tsGateway = value; }
        }

        public override ProtocolOptions Copy()
        {
            return new RdpOptions
                {
                    ConnectToConsole = this.ConnectToConsole,
                    GrabFocusOnConnect = this.GrabFocusOnConnect,
                    FullScreen = this.FullScreen,
                    UserInterface = this.UserInterface.Copy(),
                    Security = this.Security.Copy(),
                    TimeOuts = this.TimeOuts.Copy(),
                    Redirect = this.Redirect.Copy(),
                    TsGateway = this.TsGateway.Copy()
                };
        }

        public override void FromCofigFavorite(IFavorite destination, FavoriteConfigurationElement source)
        {
            throw new NotImplementedException("moved to converter");
        }

        public override void ToConfigFavorite(IFavorite source, FavoriteConfigurationElement destination)
        {
            throw new NotImplementedException("moved to converter");
        }

        //TODO internal void AssignStore(PersistenceSecurity persistenceSecurity)
        //{
        //    this.TsGateway.Security.AssignStore(persistenceSecurity);
        //}
    }
}