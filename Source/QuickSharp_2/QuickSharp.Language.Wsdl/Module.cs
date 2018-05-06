/*
 * QuickSharp Copyright (C) 2008-2011 Steve Walker.
 *
 * This file is part of QuickSharp.
 *
 * QuickSharp is free software: you can redistribute it and/or modify it under
 * the terms of the GNU Lesser General Public License as published by the Free
 * Software Foundation, either version 3 of the License, or (at your option)
 * any later version.
 *
 * QuickSharp is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License
 * for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with QuickSharp. If not, see <http://www.gnu.org/licenses/>.
 *
 */

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using QuickSharp.BuildTools;
using QuickSharp.Core;
using QuickSharp.Editor;
using QuickSharp.TextEditor;

namespace QuickSharp.Language.Wsdl
{
    public class Module : IQuickSharpPlugin
    {
        #region IQuickSharpPlugin Members

        public string GetID()
        {
            return "3B017C16-3A0D-486A-ADB4-3E0BCC1477F1";
        }

        public string GetName()
        {
            return "QuickSharp Web Services Description Language Support";
        }

        public int GetVersion()
        {
            return 1;
        }

        public string GetDescription()
        {
            return
                "Provides support for Web Services Description Language files " +
                "(.wsdl) and the .NET Framework SDK WSDL utility (wsdl.exe).";
        }

        public List<Plugin> GetDependencies()
        {
            List<Plugin> deps = new List<Plugin>();
            deps.Add(new Plugin(QuickSharpPlugins.Output, "QuickSharp.Output", 1));
            deps.Add(new Plugin(QuickSharpPlugins.BuildTools, "QuickSharp.BuildTools", 1));
            deps.Add(new Plugin(QuickSharpPlugins.Editor, "QuickSharp.Editor", 1));
            deps.Add(new Plugin(QuickSharpPlugins.TextEditor, "QuickSharp.TextEditor", 1));
            return deps;
        }

        public void Activate(MainForm mainForm)
        {
            _mainForm = mainForm;
            ActivatePlugin();
        }

        #endregion

        private BuildToolManager _buildToolManager;
        private MainForm _mainForm;
        private DocumentType _documentType;

        private void ActivatePlugin()
        {
            /*
             * Define the document handling.
             */

            _documentType = new DocumentType(Constants.DOCUMENT_TYPE_WSDL);

            DocumentManager.GetInstance().RegisterDocumentLanguage(
                _documentType, Constants.SCINTILLA_LANGUAGE_WSDL);

            ApplicationManager applicationManager =
                ApplicationManager.GetInstance();

            OpenDocumentHandler openHandler =
                applicationManager.GetOpenDocumentHandler(
                    QuickSharp.TextEditor.Constants.DOCUMENT_TYPE_TXT);

            if (openHandler != null)
                applicationManager.RegisterOpenDocumentHandler(
                    _documentType, openHandler);

            /*
             * Define the build tools.
             */

            _buildToolManager = BuildToolManager.GetInstance();

            _buildToolManager.RegisterBuildCommand(
                _documentType,
                QuickSharp.BuildTools.Constants.ACTION_COMPILE,
                CompileBuildCommand);

            if (_buildToolManager.BuildTools.GetToolCount(
                _documentType) == 0)
                CreateDefaultTools();

            _buildToolManager.UpdateTools(_documentType);
            _buildToolManager.BuildTools.SortTools();
        }

        #region Default Tools

        private void CreateDefaultTools()
        {
            BuildTool wsdl = new BuildTool(
                Guid.NewGuid().ToString(),
                _documentType, Resources.Wsdl);

            wsdl.Action = QuickSharp.BuildTools.Constants.ACTION_COMPILE;
            wsdl.Path = @"C:\Program Files\Microsoft.NET\SDK\v2.0\bin\wsdl.exe";
            wsdl.Args = "${COMMON_OPT} ${EMBEDDED_OPT} \"${SRC_FILE}\"";
            wsdl.UserArgs = "/nologo /namespace:QuickSharp";

            _buildToolManager.BuildTools.AddTool(wsdl);
            _buildToolManager.BuildTools.SelectTool(wsdl);
        }

        #endregion

        #region Build Command

        private BuildCommand CompileBuildCommand(
            BuildTool buildTool, FileInfo srcInfo)
        {
            if (srcInfo == null) return null;

            string srcText = FileTools.ReadFile(srcInfo.FullName);
            if (srcText == null) return null;

            BuildCommand buildCommand = new BuildCommand();
            buildCommand.BuildTool = buildTool;
            buildCommand.SourceInfo = srcInfo;
            buildCommand.SourceText = srcText;

            buildCommand.TargetType = ".cs";

            string targetName = Path.ChangeExtension(
                buildCommand.SourceInfo.FullName,
                buildCommand.TargetType);

            buildCommand.TargetInfo = new FileInfo(targetName);

            string path = buildTool.Path;
            path = _buildToolManager.ExpandGenericMacros(
                path, buildTool,
                buildCommand.SourceText,
                buildCommand.SourceInfo,
                buildCommand.TargetInfo);

            string args = buildTool.Args;
            args = _buildToolManager.ExpandGenericMacros(
                args, buildTool,
                buildCommand.SourceText,
                buildCommand.SourceInfo,
                buildCommand.TargetInfo);

            buildCommand.Path = path;
            buildCommand.Args = args;
            buildCommand.Cancel = false;
            buildCommand.SuccessCode = 0;

            buildCommand.StartText =
                String.Format("{0}: ", Resources.CompileStarted);
            buildCommand.FinishText =
                String.Format("{0}: ", Resources.CompileComplete);

            return buildCommand;
        }

        #endregion
    }
}

