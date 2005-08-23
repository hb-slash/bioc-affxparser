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

#ifndef _DataGroupReader_HEADER_
#define _DataGroupReader_HEADER_

/*! \file DataGroupReader.h This file provides methods to read a data dataGroup.
 */

#include "DataGroupHeader.h"
#include "DataSetReader.h"
#include <fstream>

#ifdef WIN32
#pragma warning(disable: 4290) // don't show warnings about throw keyword on function declarations.
#endif

namespace affymetrix_calvin_io
{

/*! Class to read a DataGroup */
class DataGroupReader
{
public:

	/*! Constructor
	 *	@param Reference to an open ifstream
	 *	@param Reference to a DataGroupHeader that has been initialized
	 */
	DataGroupReader(std::ifstream& o, DataGroupHeader& hdr);

	/*! Destructor */
	~DataGroupReader();

	/*! Get the number of DataSets in the DataGroup
	 *	@return DataSet count
	 */
	int32_t GetDataSetCnt() const;

	/*! Get the name of the DataGroup
	 *	@return DataGroup name
	 */
	std::wstring GetDataGroupName() const;

	/*! Get the DataSetReader by index
	 *	@param index Index of the DataSet
	 *	@exception DataSetNotFoundException
	 */
	DataSetReader GetDataSetReader(int32_t index);

	/*! Get the DataSetReader by name
	 *	@param name Name of the DataSet
	 *	@exception DataSetNotFoundException
	 */
	DataSetReader GetDataSetReader(const std::wstring& name);

private:

	/*! Open file stream */
	std::ifstream& fileStream;
	/*! Data dataGroup header that has been initialized */
	DataGroupHeader& dataGroupHdr;

};

/*! typedef of a vector of DataGroupHeaderReaders */
typedef std::vector<DataGroupReader> DataGroupReaderVector;
/*! typedef of a constant iterator of DataGroupHeaderReaders */
typedef std::vector<DataGroupReader>::iterator DataGroupReaderIt;

};

#endif // _DataGroupReader_HEADER_