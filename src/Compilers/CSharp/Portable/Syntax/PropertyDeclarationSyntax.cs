﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class PropertyDeclarationSyntax
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public SyntaxToken Semicolon
        {
            get
            {
                return this.SemicolonToken;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public PropertyDeclarationSyntax WithSemicolon(SyntaxToken semicolon)
        {
            return this.WithSemicolonToken(semicolon);
        }
    }
}
