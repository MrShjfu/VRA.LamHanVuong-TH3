/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Thu Oct 12 02:15:41 2017
* Arguments:
* "-B""macro_default""-W""dotnet:RecognitionDigits,Recog,4.0,private""-T""link:lib""-d""D:
* \Matlab\VRA.LamHanVuong.doc\Buoi
* 3\VRA.LamHanVuong-TH3\RecognitionDigits\for_testing""-v""class{Recog:D:\Matlab\VRA.LamHa
* nVuong.doc\Buoi
* 3\VRA.LamHanVuong-TH3\RecognitionDigits.m,D:\Matlab\VRA.LamHanVuong.doc\Buoi
* 3\VRA.LamHanVuong-TH3\showImageByIndex.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace RecognitionDigitsNative
{

  /// <summary>
  /// The Recog class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Matlab\VRA.LamHanVuong.doc\Buoi 3\VRA.LamHanVuong-TH3\RecognitionDigits.m
  /// <newpara></newpara>
  /// D:\Matlab\VRA.LamHanVuong.doc\Buoi 3\VRA.LamHanVuong-TH3\showImageByIndex.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class Recog : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Recog()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "RecognitionDigits.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Recog class.
    /// </summary>
    public Recog()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Recog()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the RecognitionDigits MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object RecognitionDigits()
    {
      return mcr.EvaluateFunction("RecognitionDigits", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the RecognitionDigits MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="index">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object RecognitionDigits(Object index)
    {
      return mcr.EvaluateFunction("RecognitionDigits", index);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the RecognitionDigits MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] RecognitionDigits(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "RecognitionDigits", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the RecognitionDigits MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="index">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] RecognitionDigits(int numArgsOut, Object index)
    {
      return mcr.EvaluateFunction(numArgsOut, "RecognitionDigits", index);
    }


    /// <summary>
    /// Provides an interface for the RecognitionDigits function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("RecognitionDigits", 1, 1, 0)]
    protected void RecognitionDigits(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("RecognitionDigits", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object showImageByIndex()
    {
      return mcr.EvaluateFunction("showImageByIndex", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dataImage">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object showImageByIndex(Object dataImage)
    {
      return mcr.EvaluateFunction("showImageByIndex", dataImage);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dataImage">Input argument #1</param>
    /// <param name="dataLabel">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object showImageByIndex(Object dataImage, Object dataLabel)
    {
      return mcr.EvaluateFunction("showImageByIndex", dataImage, dataLabel);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="dataImage">Input argument #1</param>
    /// <param name="dataLabel">Input argument #2</param>
    /// <param name="index">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object showImageByIndex(Object dataImage, Object dataLabel, Object index)
    {
      return mcr.EvaluateFunction("showImageByIndex", dataImage, dataLabel, index);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] showImageByIndex(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "showImageByIndex", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dataImage">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] showImageByIndex(int numArgsOut, Object dataImage)
    {
      return mcr.EvaluateFunction(numArgsOut, "showImageByIndex", dataImage);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dataImage">Input argument #1</param>
    /// <param name="dataLabel">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] showImageByIndex(int numArgsOut, Object dataImage, Object dataLabel)
    {
      return mcr.EvaluateFunction(numArgsOut, "showImageByIndex", dataImage, dataLabel);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the showImageByIndex MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="dataImage">Input argument #1</param>
    /// <param name="dataLabel">Input argument #2</param>
    /// <param name="index">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] showImageByIndex(int numArgsOut, Object dataImage, Object dataLabel, 
                               Object index)
    {
      return mcr.EvaluateFunction(numArgsOut, "showImageByIndex", dataImage, dataLabel, index);
    }


    /// <summary>
    /// Provides an interface for the showImageByIndex function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("showImageByIndex", 3, 1, 0)]
    protected void showImageByIndex(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("showImageByIndex", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
