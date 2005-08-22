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

#ifndef _AffymetrixFusionCHPDataInterface_HEADER_
#define _AffymetrixFusionCHPDataInterface_HEADER_

/*! \file FusionCHPDataAdapterInterface.h This file defines the interface between
 *	the FusionCHPData class and the Calvin and GCOS adapter classes.
 */

#include <string>
#include <list>

#include "CHPFileData.h"				// path required to distinguish between Calvin and GCOS files.
#include "CHPData.h"					// path required to distinguish between Calvin and GCOS files.
#include "FusionTagValuePairType.h"
#include "StringUtils.h"
#include "FusionProbeSetResults.h"

using namespace std;
using namespace affxchp;
using namespace affymetrix_calvin_io;
using namespace affymetrix_calvin_utilities;


namespace affymetrix_fusion_io
{

/*! \brief The types of assays. */
typedef enum _AssayType
{
	FusionExpression, 	/*! Expression assay */
	FusionGenotyping,	/*! Genotyping assay */
	FusionResequencing,	/*! Resequencing assay */
	FusionUniversal,	/*! Tag (universal) assay */
	FusionUnknown		/*! Unknown assay type */
} AssayType;

/*! \brief Converts a fusion tag/value list to a non-Fusion tag/value list
 *	\param fromList The list of name/value parameters to convert.
 *	\param toList The converted list of name/value parameters.
 */
void ConvertFusion(FusionTagValuePairTypeList& fromList, TagValuePairTypeList& toList);

/*! \brief Converts a GCOS tag/value list to a Fusion tag/value list
 *	\param fromList The list of name/value parameters to convert.
 *	\param toList The converted list of name/value parameters.
 */
void ConvertGCOS(TagValuePairTypeList& fromList, FusionTagValuePairTypeList& toList);

/*! \brief Header class for the Fusion CHP adapter */
class IFusionCHPHeaderAdapter
{
public:
// Accessors for header information.
	/*! \brief Get numbers columns.
	 *	\return Number of columns.
	 */
	virtual int GetCols() const = 0;
	/*! \brief Get number of rows.
	 *	\return Number of rows.
	 */
	virtual int GetRows() const = 0;
	/*! \brief Get the number of probesets.
	 *	\return Number of probesets.
	 */
	virtual int GetNumProbeSets() const = 0;
	/*! \brief Get assay type.
	 *	\return Assay Type.
	 *
	 *	\a	Assay Types
	 *		FusionExpression	- Expression assay
	 *		FusionGenotyping	- Genotyping assay
	 *		FusionResequencing	- Resequencing assay
	 *		FusionUniversal		- Tag (universal) assay
	 *		FusionUnknown		- Unknown assay type
	*/
	virtual AssayType GetAssayType() const = 0;
	/*! \brief Get chip type.
	 *	\return The chip type.
	 */
	virtual wstring GetChipType() const = 0;

	/*! \brief Get algorithm name.
	 *	\return Algorithm name.
	 */
	virtual wstring GetAlgName() const = 0;
	/*! \brief Get algorithm version.
	 *	\return Algorithm version number.
	 */
	virtual wstring GetAlgVersion() const = 0;
	/*! \brief Gets the algorithm parameters.
	 *	\param values Name/Value type list to be filled.
	 */
	virtual void GetAlgorithmParameters(FusionTagValuePairTypeList& values) = 0;

	/*! \brief Gets the algorithm parameter count.
	 *	\return Number of algorithm parameters.
	 */
	virtual u_int32_t GetAlgorithmParameterCount() = 0;

	/*! \brief Gets summary parameters.
	 *	\param values Name/Value type list to be filled.
	 */
	virtual void GetSummaryParameters(FusionTagValuePairTypeList& values) = 0;
	/*! \brief Gets the parent CEL file.
	 *	\return Parent CEL file name.
	 */
	virtual wstring GetParentCellFile() const = 0;
	/*! \brief Gets the prog ID.
	 *	\return Prog ID
	 */
	virtual wstring GetProgID() const = 0;
	/*! \brief Gets a specific algorithm parameter given a name/tag.
	 *	\return Specific algorithm parameter given a name/tag
	 */
	virtual wstring GetAlgorithmParameter(const wchar_t *tag) = 0;
	/*! \brief Gets a specific algorithm parameter given a name/tag.
	 *	\param tag Parameter name.
	 *	\return Specific algorithm parameter given a name/tag
	 */
	virtual wstring GetSummaryParameter(const wchar_t *tag) = 0;
	/*! \brief Gets the background zone information.
	 *	\param info Background zone information to be filled.
	 */
	virtual void GetBackgroundZoneInfo(BackgroundZoneInfo& info) = 0;
	/*! \brief Gets the list of background zone positions and values.
	 *	\param zones List of background zone positions and values to be filled.
	 */
	virtual void GetBackgroundZones(BackgroundZoneTypeList& zones) = 0;
	/*! \brief Gets the background value for a given center coordinate.
	 *	\param type Background value for a given center coordinate to be filled.
	 *	\param x X position of zone.
	 *	\param y Y position of zone.
	 */
	virtual void GetBackgroundZone(BackgroundZoneType& type, int x, int y) = 0;

	/*! \brief Gets the magic number.
	 *	\return Magic number.
	 */
	virtual int GetMagic() const = 0;

	/*! \brief Gets the version number.
	 *	\return Version number
	 */
	virtual int GetVersion() const = 0;
};

////////////////////////////////////////////////////////////////////

/*! \brief Data class for the Fusion CHP adapter */
class IFusionCHPDataAdapter
{
public:

	/*! \brief Accessors to header.
	*	\return Header object
	*/
	virtual IFusionCHPHeaderAdapter& GetHeader() = 0;

	/*! \brief Can this object read the file.
	 *	\return If the cell file can be read.
	 */
	virtual bool CanReadFile() = 0;

	/*! \brief Returns the expression probe set result
	 *	\param index Index to the result object of interest.
	 *	\param result Expression result.
	 *	\return True if the expression result was found.
	 */ 
	virtual bool GetExpressionResults(int index, affymetrix_fusion_io::FusionExpressionProbeSetResults& result) = 0;

	/*! \brief Returns the genotyping probe set result
	 *	\param index Index to the result object of interest.
	 *	\param result Genotyping result.
	 *	\return True if the genotyping result was found.
	 */
	virtual bool GetGenotypingResults(int index, FusionGenotypeProbeSetResults& result) = 0;

	/*! \brief Returns the universal (tag array) probe set result
	 *	\param index Index to the result object of interest.
	 *	\param Universal result.
	 *	\return True if the universal result was found.
	 */
	virtual bool GetUniversalResults(int index, FusionUniversalProbeSetResults& results) = 0;

	/*! \brief Gets resequencing results.
	 *	\param results Hold the resequencing results.
	 *	\return True if resequencing results were retrieved.
	 */
	virtual bool GetResequencingResults(FusionResequencingResults& results) = 0;

	/*! \brief Functions to read file. 
	 *	\return True if the cell file was read.
	 */
	virtual bool Read() = 0;

	/*! \brief Reads the header of the CHP file.
	 *	\return True if successful
	 */
	virtual bool ReadHeader() = 0;

	/*! \brief Sets the file name.
	 *	\param name Full path to the CHP file
	 */
	virtual void SetFileName(const string& value) = 0;

	/*! \brief Gets the file name.
	 *	\return Full path to the CHP file.
	 */
	virtual string GetFileName() const = 0;

	/*! \brief Deallocates any memory used by the class object. */
	virtual void Clear() = 0;
};

}

#endif //_AffymetrixFusionCHPDataInterface_HEADER_
