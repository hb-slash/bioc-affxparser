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
#ifndef _DataGroupWriter_HEADER_
#define _DataGroupWriter_HEADER_

#include "DataGroupHeader.h"
#include "DataGroupHeaderWriter.h"
#include "DataSetWriter.h"


#ifdef _MSC_VER
#pragma warning(disable: 4290) // don't show warnings about throw keyword on function declarations.
#endif

namespace affymetrix_calvin_io
{

class DataGroupWriter
{
private:

	std::ofstream* os;
	DataGroupHeader* dataGroupHdr;
	DataGroupHeaderWriter dataGroupHdrWriter;
	DataSetWriterVector writers;

public:

	DataGroupWriter(std::ofstream* o, DataGroupHeader* p);

	~DataGroupWriter();

	void WriteHeader();

	void Close() const;

	void GetDataSetWriters(DataSetWriterIt &begin, DataSetWriterIt &end);

	DataSetWriter& GetDataSetWriter(int32_t index);

	int32_t GetDataSetWriterCnt() const;

	std::wstring GetDataGroupName() const;

	DataSetWriter* CreateDataSetWriter(DataSetHeader& hdr);

	void UpdateNextDataGroupPos() const;

private:

	void CreateWriters();
};

/*! vector of DataGroupHeaderWriters */
typedef std::vector<DataGroupWriter> DataGroupWriterVector;
/*! constant iterator of DataGroupHeaderWriters */
typedef std::vector<DataGroupWriter>::iterator DataGroupWriterIt;

}

#endif // _DataGroupWriter_HEADER_
