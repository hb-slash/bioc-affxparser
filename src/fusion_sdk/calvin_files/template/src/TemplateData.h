/////////////////////////////////////////////////////////////////
//
// Copyright (C) 2005 Affymetrix, Inc.
//
// This library is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation; either version 2.1 of the License,
// or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License
// for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
/////////////////////////////////////////////////////////////////

#ifndef _TemplateData_HEADER_
#define _TemplateData_HEADER_

/*! \file TemplateData.h This file provides interfaces to store information in a template file.
 */

#include "ArrayData.h"

namespace affymetrix_calvin_array
{

/*! The identifier for a template file. */
#define TEMPLATE_FILE_TYPE_IDENTIFIER "affymetrix-calvin-template"

/*! This class provides interfaces to store array template information. */
class TemplateData : public ArrayData
{
};

};

#endif // _TemplateData_HEADER_
