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

#ifndef _GridControlFileWriter_HEADER_
#define _GridControlFileWriter_HEADER_

/*! \file GridControlFileWriter.h This file provides interfaces to write a GRC (grid control) file.
 */

#include <fstream>
#include <string>
#include "GridControlData.h"
#include "GenericFileWriter.h"

namespace affymetrix_calvin_io
{

/*! This class provide write capabilities for GRC files. */
class GridControlFileWriter
{
public:
	/*! Constructor */
	GridControlFileWriter();

	/*! Destructor */
	~GridControlFileWriter();

	/*! Write a new GRC file.
	 * @param fileName The name of the GRC file.
	 * @param data The grid control data to write to the file.
	 * @return True if successful.
	 */
	bool Write(const std::string &fileName, affymetrix_grid_control::GridControlData &data);
};

};

#endif // _GridControlFileWriter_HEADER_
