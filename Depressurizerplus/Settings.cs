﻿/*
Copyright 2014 Juan Luis Podadera.

This file is part of Depressurizer+.
https://code.google.com/p/depressurizerplus/

Depressurizer+ is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Depressurizer+ is a clone of Depressurizer application, copyright 
by Steve Labbe. Depressurizer application can be found at:
https://code.google.com/p/depressurizer/

Depressurizer+ is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Depressurizer+.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Rallion;

namespace Depressurizer {

    enum StartupAction {
        None,
        Load,
        Create
    }

    enum GameListSource {
        XmlPreferred,
        XmlOnly,
        WebsiteOnly
    }

    enum UserLanguage
    {
        windows,
        en,
        es
    }

    class Settings : AppSettings {

        private static Settings instance;

        public static Settings Instance() {
            if( instance == null ) {
                instance = new Settings();
            }
            return instance;
        }

        public string SettingsVersion {
            get {
                return "0.3";
            }
        }

        private string _steamPath = null;
        public string SteamPath {
            get {
                return _steamPath;
            }
            set {
                if( _steamPath != value ) {
                    _steamPath = value;
                    outOfDate = true;
                }
            }
        }

        private StartupAction _startupAction = StartupAction.Create;
        public StartupAction StartupAction {
            get {
                return _startupAction;
            }
            set {
                if( _startupAction != value ) {
                    _startupAction = value;
                    outOfDate = true;
                }
            }
        }

        private string _profileToLoad = null;
        public string ProfileToLoad {
            get {
                return _profileToLoad;
            }
            set {
                if( _profileToLoad != value ) {
                    _profileToLoad = value;
                    outOfDate = true;
                }
            }
        }

        private bool _removeExtraEntries = true;
        public bool RemoveExtraEntries {
            get {
                return _removeExtraEntries;
            }
            set {
                if( _removeExtraEntries != value ) {
                    _removeExtraEntries = value;
                    outOfDate = true;
                }
            }
        }

        private bool _ignoreDlc = true;
        public bool IgnoreDlc {
            get {
                return _ignoreDlc;
            }
            set {
                if( _ignoreDlc != value ) {
                    _ignoreDlc = value;
                    outOfDate = true;
                }
            }
        }

        private bool _ignoreExternal = false;
        public bool IgnoreExternal
        {
            get
            {
                return _ignoreExternal;
            }
            set
            {
                if (_ignoreExternal != value)
                {
                    _ignoreExternal = value;
                    outOfDate = true;
                }
            }
        }

        private bool _fullAutocat = false;
        public bool FullAutocat {
            get {
                return _fullAutocat;
            }
            set {
                if( _fullAutocat != value ) {
                    _fullAutocat = value;
                    outOfDate = true;
                }
            }
        }

        private GameListSource _listSource = GameListSource.XmlPreferred;
        public GameListSource ListSource {
            get {
                return _listSource;
            }
            set {
                if( _listSource != value ) {
                    _listSource = value;
                    outOfDate = true;
                }
            }
        }

        private LoggerLevel _logLevel = LoggerLevel.Info;
        public LoggerLevel LogLevel {
            get {
                return _logLevel;
            }
            set {
                Program.Logger.Level = value;
                if( _logLevel != value ) {
                    _logLevel = value;
                    outOfDate = true;
                }
            }
        }

        private int _logSize = 2000000;
        public int LogSize {
            get {
                return _logSize;
            }
            set {
                Program.Logger.MaxFileSize = value;
                if( _logSize != value ) {
                    _logSize = value;
                    outOfDate = true;
                }
            }
        }

        private int _logBackups = 1;
        public int LogBackups {
            get {
                return _logBackups;
            }
            set {
                Program.Logger.MaxBackup = value;
                if( _logBackups != value ) {
                    _logBackups = value;
                    outOfDate = true;
                }
            }
        }

        private UserLanguage _userLanguage = UserLanguage.windows;
        public UserLanguage UserLang
        {
            get
            {
                return _userLanguage;
            }
            set
            {
                if (_userLanguage != value)
                {
                    _userLanguage = value;
                    outOfDate = true;
                    changeLanguage(_userLanguage);
                }
            }
        }

        private void changeLanguage(UserLanguage userLanguage)
        {
            CultureInfo newCulture;

            switch (userLanguage)
            {
                case UserLanguage.en:
                    newCulture = new CultureInfo("en");
                    break;
                case UserLanguage.es:
                    newCulture = new CultureInfo("es");
                    break;
                default:
                    newCulture = Thread.CurrentThread.CurrentCulture;
                    break;
            }

            Thread.CurrentThread.CurrentUICulture = newCulture;
        }

        private Settings()
            : base() {
            FilePath = System.Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData ) + @"\Depressurizer\Settings.xml";
        }

        public override void Load() {
            base.Load();
         //   Program.Logger.Level = LogLevel;
        }
    }
}
