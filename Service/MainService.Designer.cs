﻿/*
  GameSrv: A BBS Door Game Server
  Copyright (C) 2002-2013  Rick Parrish, R&M Software

  This file is part of GameSrv.

  GameSrv is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  GameSrv is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with GameSrv.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace RandM.GameSrv
{
    partial class svcMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _GameSrv.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // svcMain
            // 
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.ServiceName = "GameSrvService";

        }

        #endregion
    }
}
