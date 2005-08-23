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

#include "DataGroupHeaderReader.h"
#include "DataSetHeaderReader.h"
#include "FileInput.h"
#include <sys/stat.h>
#include <sys/types.h>

using namespace affymetrix_calvin_io;

/*
 * Constructor
 */
DataGroupHeaderReader::DataGroupHeaderReader()
{
}

/*
 * Reads all the DataGroupHeaders in a file and the minimum information for each DataSetHeader in every DataGroup.
 */
void DataGroupHeaderReader::ReadAllMinimumInfo(std::ifstream& fileStream, FileHeader& fh, u_int32_t dataGroupCnt)
{
	// Get the first data group offset
	u_int32_t nextDataGroupFilePos = fh.GetFirstDataGroupFilePos();

	for (u_int32_t i = 0; i < dataGroupCnt; ++i)
	{
		// Read the DataGroupHeader
		DataGroupHeader dch;

		// Move to the indicated position in the file
		fileStream.seekg(nextDataGroupFilePos, std::ios_base::beg);

		nextDataGroupFilePos = ReadMinimumInfo(fileStream, dch);
		fh.AddDataGroupHdr(dch);
	}
}

/*
 * Reads all the DataGroupHeaders in a file and all information for each DataSetHeader in every DataGroup.
 */
void DataGroupHeaderReader::ReadAll(std::ifstream& fileStream, FileHeader& fh, u_int32_t dataGroupCnt)
{
	// Get the first data group offset
	u_int32_t nextDataGroupFilePos = fh.GetFirstDataGroupFilePos();

	for (u_int32_t i = 0; i < dataGroupCnt; ++i)
	{
		// Read the DataGroupHeader
		DataGroupHeader dch;

		// Move to the indicated position in the file
		fileStream.seekg(nextDataGroupFilePos, std::ios_base::beg);

		nextDataGroupFilePos = Read(fileStream, dch);
		fh.AddDataGroupHdr(dch);
	}
}

/*
 * Reads the DataGroupHeader and the minimum information for all DataSetHeaders associated with this DataGroupHeader from the file.
 */
u_int32_t DataGroupHeaderReader::ReadMinimumInfo(std::ifstream& fileStream, DataGroupHeader& dch)
{
	u_int32_t dataSetCnt = ReadHeader(fileStream, dch);

	// Read the DataSets
	DataSetHeaderReader dphReader;
	dphReader.ReadAllMinimumInfo(fileStream, dch, dataSetCnt);
	return dch.GetNextCubePos();
}

/*
 * Read the DataGroupHeader and all DataSetHeaders associated with this DataGroupHeader from the file.
 */
u_int32_t DataGroupHeaderReader::Read(std::ifstream& fileStream, DataGroupHeader& dch)
{
	u_int32_t dataSetCnt = ReadHeader(fileStream, dch);

	// Read the DataSets
	DataSetHeaderReader dphReader;
	dphReader.ReadAll(fileStream, dch, dataSetCnt);
	return dch.GetNextCubePos();
}

/*
 * Reads the DataGroupHeader from the file.  Doesn't read all DataSetHeader information.
 */
u_int32_t DataGroupHeaderReader::ReadHeader(std::ifstream& fileStream, DataGroupHeader& dch)
{
	ReadNextDataGroupFilePos(fileStream, dch);
	ReadFirstDataSetFilePos(fileStream, dch);
	u_int32_t dataSetCnt = ReadDataSetCnt(fileStream, dch);
	ReadDataGroupName(fileStream, dch);
	return dataSetCnt;
}

/*
 * Reads the file position of the next DataGroup from the file.
 */
void DataGroupHeaderReader::ReadNextDataGroupFilePos(std::ifstream& fileStream, DataGroupHeader& dch)
{
	dch.SetNextCubePos(FileInput::ReadUInt32(fileStream));
}

/*
 * Reads the file position of the first DataSet in the DataGroup.
 */
void DataGroupHeaderReader::ReadFirstDataSetFilePos(std::ifstream& fileStream, DataGroupHeader& dch)
{
	dch.SetDataSetPos(FileInput::ReadUInt32(fileStream));
}

/*
 * Reads the number of DataSets in the current DataGroup from the file.
 */
u_int32_t DataGroupHeaderReader::ReadDataSetCnt(std::ifstream& fileStream, DataGroupHeader& dch)
{
	return FileInput::ReadUInt32(fileStream);
}

/*
 * Reads the DataGroup name from the file.
 */
void DataGroupHeaderReader::ReadDataGroupName(std::ifstream& fileStream, DataGroupHeader& dch)
{
	dch.SetName(FileInput::ReadString16(fileStream));
}