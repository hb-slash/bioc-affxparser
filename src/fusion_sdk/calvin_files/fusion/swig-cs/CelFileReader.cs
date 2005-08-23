/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CelFileReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CelFileReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CelFileReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CelFileReader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CelFileReader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CelFileReader() : this(affx_fusionPINVOKE.new_CelFileReader(), true) {
  }

  public string GetFilename() {
    string ret = affx_fusionPINVOKE.CelFileReader_GetFilename(swigCPtr);
    return ret;
  }

  public void SetFilename(string name) {
    affx_fusionPINVOKE.CelFileReader_SetFilename(swigCPtr, name);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Read(CelFileData data) {
    affx_fusionPINVOKE.CelFileReader_Read(swigCPtr, CelFileData.getCPtr(data));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

}