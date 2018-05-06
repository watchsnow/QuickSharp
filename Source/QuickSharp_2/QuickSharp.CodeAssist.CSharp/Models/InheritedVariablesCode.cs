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

namespace QuickSharp.CodeAssist.CSharp
{
    public class InheritedVariablesCode : InheritedVariablesBase
    {
        public InheritedVariablesCode(
            string source,
            DeclarationContext declarationContext,
            List<string> workspaceAssemblies,
            List<string> fullNamespaces,
            List<string> rootNamespaces,
            List<string> configNamespaces)
            : base(
                source,
                declarationContext,
                workspaceAssemblies,
                fullNamespaces,
                rootNamespaces,
                configNamespaces)
        {
        }

        protected override List<string> GetBaseTypes(string source)
        {
            return GetCodeBaseTypeList(source);
        }

        protected override List<String> GetNamespaceList(string source)
        {
            return GetCodeDeclaredNamespaceList(source);
        }
    }
}
