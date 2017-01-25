using System.Collections.Generic;

namespace CryptoWizard.Services
{
  public class Inverse
  {
    /// <summary>
    /// This method inverse the point
    /// </summary>
    /// <param name="x1">The first point</param>
    /// <param name="y1">The first point</param>
    /// <param name="p">Mod</param>
    /// <returns>Return inverse point</returns>
    public IEnumerable<int> InverseResult(int x1, int y1, int p)
    {
      return new int[] { x1, p - y1 };
    }
  }
}
