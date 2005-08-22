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


#ifndef _AffymetrixFusionFactory_HEADER_
#define _AffymetrixFusionFactory_HEADER_

#include "FusionDatData.h"
#include "FusionDatFileWriter.h"

/*! \file FusionFactory.h This file defines the Fusion Factory class
 */

namespace affymetrix_fusion_io
{
/*! A class for creating fusion objects */
class FusionFactory
{
public:
	/*! Creates a FusionDatData object.  Call Delete on the object to free memory
	 *	@return Newly created FusionDatData object 
	 */
	static FusionDatData* CreateDatData();
	/*! Creates a FusiontDatFileWriter object. Call Delete on the object to free memory
	 *	@return Newly created FustionDatFileWriter object
	 */
	static FusionDatFileWriter* CreateDatFileWriter();
};
}

#endif